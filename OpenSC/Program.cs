﻿using OpenSC.GUI.WorkspaceManager;
using OpenSC.Logger;
using OpenSC.Model;
using OpenSC.Model.Settings;
using OpenSC.Model.Signals;
using OpenSC.Model.Variables;
using OpenSC.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSC
{

    static class Program
    {

        private const string LOG_TAG = "ProgramEntry";

        private static GUI.SplashScreen splashScreen = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Logger
            string loggerDirectory = Application.StartupPath + Path.DirectorySeparatorChar + "log";
            FileLogger logger = new FileLogger(loggerDirectory, "opensc");
            LogDispatcher.I(LOG_TAG, "Main() started, created file logger.");

            // Init Win32 GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Splash screen
            splashScreen = new GUI.SplashScreen();
            splashScreen.Show();
            splashScreen.Status = "Initializing components...";
            Application.DoEvents();

            // Thread helpers init
            ThreadHelpers.InvokeHelper.Init();

            // Start components
            StartupController.StatusChanged += startupControllerStatusChangedHandler;
            StartupController.ProgramStarted();
            StartupController.GuiInitializable();

            // Main message loop
            GUI.MainForm.Instance.Load += mainFormOpenedHandler;
            Application.Run(GUI.MainForm.Instance);

        }

        private static void startupControllerStatusChangedHandler(string status)
        {
            splashScreen.Status = status;
            Application.DoEvents();
        }

        private static void mainFormOpenedHandler(object sender, EventArgs e)
        {
            LogDispatcher.I(LOG_TAG, "Main form opened.");
            StartupController.MainWindowOpened();
            splashScreen.Status = "Program started.";
            splashScreen.Close();
        }

    }

}
