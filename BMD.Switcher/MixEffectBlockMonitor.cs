﻿using BMDSwitcherAPI;
using System;
using ThreadHelpers;

namespace BMD.Switcher
{

    public class MixEffectBlockMonitor : IBMDSwitcherMixEffectBlockCallback, IDisposable
    {

        public IBMDSwitcherMixEffectBlock MixEffectBlock { get; private set; }

        public MixEffectBlockMonitor(IBMDSwitcherMixEffectBlock mixEffectBlock)
        {
            MixEffectBlock = mixEffectBlock;
            MixEffectBlock.AddCallback(this);
        }

        public void PropertyChanged(_BMDSwitcherMixEffectBlockPropertyId propertyId)
        {
            switch (propertyId)
            {
                case _BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput:
                    InvokeHelper.Invoke(() =>
                    {
                        MixEffectBlock.GetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, out long programInput);
                        ProgramInput = programInput;
                    });
                    break;
                case _BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput:
                    InvokeHelper.Invoke(() =>
                    {
                        MixEffectBlock.GetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, out long previewInput);
                        PreviewInput = previewInput;
                    });
                    break;
            }
        }

        public void Dispose()
        {
            MixEffectBlock.RemoveCallback(this);
            ProgramInputChanged = null;
            PreviewInputChanged = null;
        }

        #region Program input
        public delegate void ProgramInputChangedDelegate(IBMDSwitcherMixEffectBlock meBlock, MixEffectBlockMonitor monitor, long input);
        public event ProgramInputChangedDelegate ProgramInputChanged;

        private long programInput;

        public long ProgramInput
        {
            get => programInput;
            set
            {
                if (value == programInput)
                    return;
                programInput = value;
                ProgramInputChanged?.Invoke(MixEffectBlock, this, value);
            }
        }
        #endregion

        #region Preview input
        public delegate void PreviewInputChangedDelegate(IBMDSwitcherMixEffectBlock meBlock, MixEffectBlockMonitor monitor, long input);
        public event PreviewInputChangedDelegate PreviewInputChanged;

        private long previewInput;

        public long PreviewInput
        {
            get => previewInput;
            set
            {
                if (value == previewInput)
                    return;
                previewInput = value;
                PreviewInputChanged?.Invoke(MixEffectBlock, this, value);
            }
        }
        #endregion

    }

}
