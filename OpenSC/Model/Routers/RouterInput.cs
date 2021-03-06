﻿using OpenSC.Model.General;
using OpenSC.Model.Signals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Routers
{

    public class RouterInput : INotifyPropertyChanged, IRouterOutputAssignable
    {

        public RouterInput()
        { }

        public RouterInput(string name, Router router, int index)
        {
            this.name = name;
            this.Router = router;
            this.Index = index;
        }

        public void Restored()
        { }
        
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                if (value == name)
                    return;
                string oldName = name;
                name = value;
                NameChanged?.Invoke(this, oldName, value);
                PropertyChanged?.Invoke(nameof(Name));
            }
        }

        public delegate void NameChangedDelegate(RouterInput input, string oldName, string newName);
        public event NameChangedDelegate NameChanged;

        public Router Router { get; internal set; }

        public void RemovedFromRouter(Router router)
        {
            if (router != Router)
                return;
        }

        private int index;

        public int Index
        {
            get { return index; }
            internal set { index = value; }
        }

        ISignal source;

        public ISignal Source
        {
            get { return source; }
            set
            {

                if (value == source)
                    return;
                ISignal oldSource = source;

                SourceChanging?.Invoke(this, oldSource, value);

                if (source != null)
                {
                    source.SourceSignalNameChanged -= sourceSignalNameChangedHandler;
                    source.RedTallyChanged -= sourceRedTallyChangedHandler;
                    source.GreenTallyChanged -= sourceGreenTallyChangedHandler;
                }
                
                source = value;
                IsTieline = (source is RouterOutput);

                SourceChanged?.Invoke(this, oldSource, value);
                PropertyChanged?.Invoke(nameof(Source));

                SourceNameChanged?.Invoke(this, source?.SignalLabel);
                RedTallyChanged?.Invoke(this, (source?.RedTally == true));
                GreenTallyChanged?.Invoke(this, (source?.GreenTally == true));

                if (source != null)
                {
                    source.SourceSignalNameChanged += sourceSignalNameChangedHandler;
                    source.RedTallyChanged += sourceRedTallyChangedHandler;
                    source.GreenTallyChanged += sourceGreenTallyChangedHandler;
                }

            }
        }

        public delegate void SourceChangingDelegate(RouterInput input, ISignal oldSource, ISignal newSource);
        public event SourceChangingDelegate SourceChanging;

        public delegate void SourceChangedDelegate(RouterInput input, ISignal oldSource, ISignal newSource);
        public event SourceChangedDelegate SourceChanged;

        // "Temp foreign key"
        public string _sourceSignalUniqueId;

        public void RestoreSource()
        {
            if (_sourceSignalUniqueId != null)
                Source = SignalRegister.Instance.GetSignalByUniqueId(_sourceSignalUniqueId);
            TielineCost = _tielineCost;
            TielineIsReserved = _tielineIsReserved;
        }

        public string SourceSignalName
        {
            get => source?.SourceSignalName;
        }

        public string GetSourceSignalName(List<object> recursionChain = null)
        {
            if (source == null)
                return null;
            if (recursionChain == null)
                recursionChain = new List<object>();
            if (recursionChain.Contains(this))
                return "(cyclic tieline)";
            recursionChain.Add(this);
            return source.GetSourceSignalName(recursionChain);
        }

        public delegate void RouterInputSourceNameChanged(RouterInput input, string newName);
        public event RouterInputSourceNameChanged SourceNameChanged;

        #region Property: SourceSignal
        public ExternalSignal SourceSignal
            => GetSourceSignal();

        public ExternalSignal GetSourceSignal(List<object> recursionChain = null)
        {
            if (source == null)
                return null;
            if (source is ExternalSignal)
                return ((ExternalSignal)source);
            if (!(source is RouterOutput))
                return null;
            if (recursionChain == null)
                recursionChain = new List<object>();
            if (recursionChain.Contains(this))
                return null;
            recursionChain.Add(this);
            return ((RouterOutput)source).GetSourceSignal(recursionChain);
        }

        public event SourceSignalChangedDelegate SourceSignalChanged;
        #endregion

        private void sourceSignalNameChangedHandler(ISignal inputSource, string newName)
        {
            SourceNameChanged?.Invoke(this, newName);
        }

        public bool RedTally =>
            (source != null) ? source.RedTally : false;

        public bool GreenTally =>
            (source != null) ? source.GreenTally : false;

        public bool GetRedTally(List<object> recursionChain = null)
        {
            if (source == null)
                return false;
            if (recursionChain == null)
                recursionChain = new List<object>();
            if (recursionChain.Contains(this))
                return false;
            recursionChain.Add(this);
            return source.GetRedTally(recursionChain);
        }

        public bool GetGreenTally(List<object> recursionChain = null)
        {
            if (source == null)
                return false;
            if (recursionChain == null)
                recursionChain = new List<object>();
            if (recursionChain.Contains(this))
                return false;
            recursionChain.Add(this);
            return source.GetGreenTally(recursionChain);
        }

        public delegate void TallyChangedDelegate(RouterInput input, bool newState);
        public event TallyChangedDelegate RedTallyChanged;
        public event TallyChangedDelegate GreenTallyChanged;

        private void sourceRedTallyChangedHandler(ISignal inputSource, bool oldState, bool newState)
        {
            RedTallyChanged?.Invoke(this, newState);
        }

        private void sourceGreenTallyChangedHandler(ISignal inputSource, bool oldState, bool newState)
        {
            GreenTallyChanged?.Invoke(this, newState);
        }

        #region Implementation of INotifyPropertyChanged
        public event PropertyChangedDelegate PropertyChanged;
        #endregion

        #region Tieline properties
        private bool isTieline;

        public bool IsTieline
        {
            get => isTieline;
            private set
            {
                if (value == isTieline)
                    return;
                isTieline = value;
                IsTielineChanged?.Invoke(this, !isTieline, isTieline);
                PropertyChanged?.Invoke(nameof(IsTieline));
            }
        }

        public delegate void IsTielineChangedDelegate(RouterInput input, bool oldValue, bool newValue);
        public event IsTielineChangedDelegate IsTielineChanged;

        // Temporal until restore
        public int _tielineCost;

        private int tielineCost;

        public int? TielineCost
        {
            get => (IsTieline) ? (int?)tielineCost : null;
            set
            {
                if (!IsTieline)
                    return;
                if (value == tielineCost)
                    return;
                int? oldValue = tielineCost;
                tielineCost = (int)value;
                TielineCostChanged?.Invoke(this, oldValue, tielineCost);
                PropertyChanged?.Invoke(nameof(TielineCost));
            }
        }

        public delegate void TielineCostChangedDelegate(RouterInput input, int? oldValue, int? newValue);
        public event TielineCostChangedDelegate TielineCostChanged;

        // Temporal until restore
        public bool _tielineIsReserved;

        private bool tielineIsReserved;

        public bool? TielineIsReserved
        {
            get => (IsTieline) ? (bool?)tielineIsReserved : null;
            set
            {
                /*if (!IsTieline)
                    return;*/
                if (value == tielineIsReserved)
                    return;
                bool? oldValue = tielineIsReserved;
                tielineIsReserved = (bool)value;
                TielineIsReservedChanged?.Invoke(this, oldValue, tielineIsReserved);
                PropertyChanged?.Invoke(nameof(TielineIsReserved));
            }
        }

        public delegate void TielineIsReservedChangedDelegate(RouterInput input, bool? oldValue, bool? newValue);
        public event TielineIsReservedChangedDelegate TielineIsReservedChanged;
        #endregion

    }

}
