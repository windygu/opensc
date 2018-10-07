﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSC.GUI
{
    public partial class ChildWindowBase : Form
    {
        public ChildWindowBase()
        {
            InitializeComponent();
            
        }

        public void ShowAsChild()
        {
            MdiParent = MainForm.Instance;
            Show();
        }
    }
}
