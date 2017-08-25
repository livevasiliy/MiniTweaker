using System;
using System.Windows.Forms;

namespace WinServiceApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Service service = new Service();
        Registr registr = new Registr();

        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            StateChecked();
        }

        /// <summary>
        /// Вызов процедур выбранным параметрам.
        /// </summary>
        private void StateChecked()
        {
            if (serviceCheckbox.CheckState == CheckState.Checked)
                service.DisabledService();

            if (DisableNetworkPrint_checkBox.CheckState == CheckState.Checked)
                registr.DisableNetworkPrint();

            if (DontUnloadRAMCodeDriver_checkBox.CheckState == CheckState.Checked)
                registr.DontUnloadRAMCodeDriver();

            if (DontUnloadRAMCode_checkBox.CheckState == CheckState.Checked)
                registr.DontUnloadRAMCode();

            if (ClearPageFileAtShutdown_checkBox.CheckState == CheckState.Checked)
                registr.ClearPageFileAtShutdown();

            if (DisableAutoUpdate_checkBox.CheckState == CheckState.Checked)
                registr.KillServiceTimeout();

            if (DisableAutoRunCD_checkBox.CheckState == CheckState.Checked)
                registr.DisableThumbailCache();

            if (DisableThumbailCache_checkBox.CheckState == CheckState.Checked)
                registr.DisableAutoRunCD();

            if (KillServiceTimeout_checkBox.CheckState == CheckState.Checked)
                registr.DisableAutoUpdate();

            if (UpPrioritySeparation_checkBox.CheckState == CheckState.Checked)
                registr.SpeedStart();

            if (UpSpeedNTFS_checkBox.CheckState == CheckState.Checked)
                registr.DisableHistoryLastDocs();

            if (DisableHistoryLastDocs_checkBox.CheckState == CheckState.Checked)
                registr.UpSpeedNTFS();

            if (SpeedStart_checkBox.CheckState == CheckState.Checked)
                registr.UpPrioritySeparation();

            if (DisableShowInfoTip_checkBox.CheckState == CheckState.Checked)
                registr.DisableShowInfoTip();
            else
                MessageBox.Show("Не выбран ни один из параметров !").ToString();
        }

        private void AboutAs_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
