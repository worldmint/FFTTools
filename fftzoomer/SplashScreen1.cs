﻿using System;
using DevExpress.XtraSplashScreen;

namespace fftzoomer
{
    public partial class SplashScreen1 : SplashScreen
    {
        public enum SplashScreenCommand
        {
        }

        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}