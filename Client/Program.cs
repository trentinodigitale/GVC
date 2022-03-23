using System;
using System.Collections.Generic;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.MDIForm;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Client
{
    static class Program
    {

	
        #region Event Handlers 

        private static void engine_BeforeInitializeApplicationEnvironment(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        private static void engine_InitializeMDIForm(object sender, EventArgs e)
        {
            OeF.Engine.ApplicationEngine engine = sender as OeF.Engine.ApplicationEngine;
            it.dedagroup.GVC.Client.Forms.MDIForm.Main mainForm = 
                new it.dedagroup.GVC.Client.Forms.MDIForm.Main();
            engine.MDIForm = mainForm;  
           
        }

        private static void engine_InitializeUserEnvironment(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OeF.Engine.ApplicationEngine engine = sender as OeF.Engine.ApplicationEngine;

            it.dedagroup.GVC.Repository.Common.FDT.UtenteFDT user = it.dedagroup.GVC.Client.Forms.Engine.GVCSystemEngine.Login();
            if (user == null)
            {
                e.Cancel = true;
            }
            else
            {
                engine.UserEnvironment = new OeF.Profiles.GenericPrincipal(new OeF.Profiles.GenericIdentity(user.UserName, String.Empty, String.Empty), user.Ruoli);
                engine.UserEnvironment.Culture = new System.Globalization.CultureInfo("it-IT");
            }
        }

		#endregion Event Handlers 

		#region Private Methods (2) 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            try
            {
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetStyle(DevExpress.LookAndFeel.LookAndFeelStyle.Skin, false, true);
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Asphalt World");

               // UpgradeSettings();

                OeF.Engine.ApplicationEngine engine = new OeF.Engine.ApplicationEngine();

                engine.InitializeUserEnvironment += new System.ComponentModel.CancelEventHandler(engine_InitializeUserEnvironment);
                engine.BeforeInitializeApplicationEnvironment += new System.ComponentModel.CancelEventHandler(engine_BeforeInitializeApplicationEnvironment);
                engine.InitializeMDIForm += new EventHandler(engine_InitializeMDIForm);
                if (!engine.Run(args, Properties.Settings.Default))
                {
                    
                    Application.Exit();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                OeF.Forms.OeFMessageBox.Show(Properties.Resources.ErrorFatalMessage,
                    Properties.Resources.ErrorFatalCaption,
                    ex.ToString(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Upgrades the settings.
        /// </summary>
        private static void UpgradeSettings()
        {
            try
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                String settingVersion = assembly.GetName().Version.ToString();

                if (Properties.Settings.Default.SettingVersion != settingVersion)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.SettingVersion = settingVersion;
                    Properties.Settings.Default.Save();
                }
            }
            catch { }
        }

		#endregion Private Methods 

    }
}
