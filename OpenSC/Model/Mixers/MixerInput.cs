﻿using OpenSC.Model.General;
using OpenSC.Model.Signals;
using OpenSC.Model.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.Mixers
{

    public class MixerInput : ISignalTallySource, INotifyPropertyChanged
    {

        public MixerInput()
        { }

        public MixerInput(string name, Mixer mixer, int index)
        {
            this.name = name;
            this.Mixer = mixer;
            this.Index = index;
            createBooleans();
        }

        public void Restored()
        {
            restoreSource();
            createBooleans();
        }

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

        public delegate void InputNameChangedDelegate(MixerInput input, string oldName, string newName);
        public event InputNameChangedDelegate NameChanged;

        public Mixer Mixer { get; internal set; }

        public void RemovedFromMixer(Mixer mixer)
        {
            if (mixer != Mixer)
                return;
        }

        #region Property: Index
        private int index;

        public int Index
        {
            get { return index; }
            set {
                if (value == index)
                    return;
                int oldIndex = index;
                index = value;
                IndexChanged?.Invoke(this, oldIndex, value);
                PropertyChanged?.Invoke(nameof(Index));
            }
        }

        public delegate void IndexChangedDelegate(MixerInput input, int oldIndex, int newIndex);
        public event IndexChangedDelegate IndexChanged;
        #endregion

        #region Property: Source
        private ISignal source;

        public ISignal Source
        {
            get { return source; }
            set
            {

                if (value == source)
                    return;

                if(source != null)
                {
                    source.SignalLabelChanged -= signalLabelChangedHandler;
                    source.IsTalliedFrom(this, SignalTallyType.Red, false);
                    source.IsTalliedFrom(this, SignalTallyType.Green, false);
                }

                ISignal oldSource = source;
                source = value;

                SourceChanged?.Invoke(this, oldSource, value);
                PropertyChanged?.Invoke(nameof(Source));

                SourceSignalLabelChanged?.Invoke(this, source?.SignalLabel);
                PropertyChanged?.Invoke(nameof(SourceName));

                if (source != null)
                {
                    source.SignalLabelChanged += signalLabelChangedHandler;
                    source.IsTalliedFrom(this, SignalTallyType.Red, RedTally);
                    source.IsTalliedFrom(this, SignalTallyType.Green, GreenTally);
                }

            }
        }

        public delegate void SourceChangedDelegate(MixerInput input, ISignal oldSource, ISignal newSource);
        public event SourceChangedDelegate SourceChanged;
        #endregion

        #region Property: SourceName
        public string SourceName
        {
            get => source.SignalLabel;
        }

        private void signalLabelChangedHandler(ISignal signal, string newLabel)
        {
            SourceSignalLabelChanged?.Invoke(this, newLabel);
        }

        public delegate void SourceSignalLabelChangedDelegate(MixerInput input, string newName);
        public SourceSignalLabelChangedDelegate SourceSignalLabelChanged;
        #endregion

        // "Temp foreign key"
        public string _sourceSignalUniqueId;

        private void restoreSource()
        {
            if (_sourceSignalUniqueId != null)
                Source = SignalRegister.Instance.GetSignalByUniqueId(_sourceSignalUniqueId);
        }

        public delegate void TallyChangedDelegate(MixerInput input, bool newState);

        private bool redTally;

        public bool RedTally
        {
            get => redTally;
            set
            {
                if (value == redTally)
                    return;
                redTally = value;
                RedTallyChanged?.Invoke(this, value);
                source?.IsTalliedFrom(this, SignalTallyType.Red, value);
            }
        }

        public event TallyChangedDelegate RedTallyChanged;

        private bool greenTally;

        public bool GreenTally
        {
            get => greenTally;
            set
            {
                if (value == greenTally)
                    return;
                greenTally = value;
                GreenTallyChanged?.Invoke(this, value);
                source?.IsTalliedFrom(this, SignalTallyType.Green, value);
            }
        }

        public event TallyChangedDelegate GreenTallyChanged;

        #region Tally booleans
        private IBoolean redTallyBoolean = null;
        private IBoolean greenTallyBoolean = null;

        private void createBooleans()
        {
            redTallyBoolean = new MixerInputTallyBoolean(this, MixerInputTallyBoolean.TallyColor.Red);
            greenTallyBoolean = new MixerInputTallyBoolean(this, MixerInputTallyBoolean.TallyColor.Green);
            BooleanRegister.Instance.RegisterBoolean(redTallyBoolean);
            BooleanRegister.Instance.RegisterBoolean(greenTallyBoolean);
        }

        private void removeBooleans()
        {
            if (redTallyBoolean != null)
            {
                BooleanRegister.Instance.UnregisterBoolean(redTallyBoolean);
                redTallyBoolean = null;
            }
            if (greenTallyBoolean != null)
            {
                BooleanRegister.Instance.UnregisterBoolean(greenTallyBoolean);
                greenTallyBoolean = null;
            }
        }
        #endregion

        #region Implementation of INotifyPropertyChanged
        public event PropertyChangedDelegate PropertyChanged;
        #endregion

    }

}
