using System;
using System.ServiceProcess;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinServiceApp
{
    class Service
    {
        /// <summary>
        /// Остановка не нужных служб Windows.
        /// </summary>
        public void DisabledService()
        {
            ServiceController[] serviceController = new ServiceController[]
            {
                new ServiceController ("wuauserv"),
                new ServiceController ("wscsvc"),
                new ServiceController ("idsvc"),
                new ServiceController ("napagent"),
                new ServiceController ("iphlpsvc"),
                new ServiceController ("seclogon"),
                new ServiceController ("p2psvc"),
                new ServiceController ("RasAuto"),
                new ServiceController ("Spooler"),
                new ServiceController ("p2pimsvc"),
                new ServiceController ("pla"),
                new ServiceController ("WinDefend"),
                new ServiceController ("ProtectedStorage"),
                new ServiceController ("SessionEnv"),
                new ServiceController ("SCPolicySvc"),
                new ServiceController ("swprv"),
                new ServiceController ("HomeGroupListener"),
                new ServiceController ("Wecsvc"),
                new ServiceController ("Netlogon"),
                new ServiceController ("W32Time"),
                new ServiceController ("StiSvc"),
                new ServiceController ("BDESVC"),
                new ServiceController ("SCardSvr"),
                new ServiceController ("TermService"),
                new ServiceController ("WdiSystemHost"),
                new ServiceController ("WdiServiceHost"),
                new ServiceController ("fdPHost"),
            };

            try
            {
                for (int i = 0; i < serviceController.Length; i++)
                {
                    if (serviceController[i].Status == ServiceControllerStatus.Stopped) continue;
                    else
                    {
                        serviceController[i].Stop();
                        serviceController[i].WaitForStatus(ServiceControllerStatus.Stopped);
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Ошибка в" + e.ToString());
                Application.Exit();
            }
        }
    }
}
