﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSC.Model.UMDs
{
    public interface IUMDType
    {
        string Name { get; }
        int TallyCount { get; }
    }
}
