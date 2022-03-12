﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Scenario3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("6d5e3b29-ec50-4acc-ac57-c6783ffd159f", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Scenario3Repository repository.
        /// </summary>
        public static Scenario3Repository repo = Scenario3Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.GirişYap' at 27;8.", repo.ApplicationUnderTest.GirişYapInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.GirişYap.Click("27;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.UEyeOl1'.", repo.ApplicationUnderTest.UEyeOl1Info, new RecordItemIndex(1));
            Validate.Exists(repo.ApplicationUnderTest.UEyeOl1Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UEyeOl1' at 14;9.", repo.ApplicationUnderTest.UEyeOl1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.UEyeOl1.Click("14;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RegisterEmail' at 43;27.", repo.ApplicationUnderTest.RegisterEmailInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.RegisterEmail.Click("43;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ' ' with focus on 'ApplicationUnderTest.RegisterEmail'.", repo.ApplicationUnderTest.RegisterEmailInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.RegisterEmail.PressKeys(" ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TyCheck' at 4;4.", repo.ApplicationUnderTest.TyCheckInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TyCheck.Click("4;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RegisterPasswordInput' at 31;21.", repo.ApplicationUnderTest.RegisterPasswordInputInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.RegisterPasswordInput.Click("31;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ' ' with focus on 'ApplicationUnderTest.RegisterPasswordInput'.", repo.ApplicationUnderTest.RegisterPasswordInputInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.RegisterPasswordInput.PressKeys(" ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Fill1' at 4;4.", repo.ApplicationUnderTest.Fill1Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Fill1.Click("4;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.QButtonQButtonMediumQFluidQPrima' at 113;17.", repo.ApplicationUnderTest.QButtonQButtonMediumQFluidQPrimaInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.QButtonQButtonMediumQFluidQPrima.Click("113;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.EPostaVeŞifreniziGiriniz'.", repo.ApplicationUnderTest.EPostaVeŞifreniziGirinizInfo, new RecordItemIndex(10));
            Validate.Exists(repo.ApplicationUnderTest.EPostaVeŞifreniziGirinizInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
