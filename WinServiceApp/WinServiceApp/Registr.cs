using System;
using Microsoft.Win32;

namespace WinServiceApp
{
    class Registr
    {
        /// <summary>
        /// Отключение поиска сетевых принтеров
        /// </summary>
        public void DisableNetworkPrint()
        {
            RegistryKey print = Registry.LocalMachine;
            print.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\RemoteComputer\NameSpace\{863aa9fd-42df-457b-8e4d-0de1b8015c60}", true);
            print.Close();
        }

        /// <summary>
        /// Выгрузка из памяти неиспользуемых DLL
        /// </summary>
        public void UnloadingMemoryDLL()
        {
            RegistryKey unloadingMemoryDLL = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", true);
            unloadingMemoryDLL.SetValue("AlwaysUnloadDll", 1, RegistryValueKind.DWord);
            unloadingMemoryDLL.Close();
        }

        /// <summary>
        /// Не выгружать из оперативной памяти коды ядра и драйверов
        /// </summary>
        public void DontUnloadRAMCodeDriver()
        {
            RegistryKey dontUnloadRAMDriver = Registry.LocalMachine.OpenSubKey(@"\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", true);
            dontUnloadRAMDriver.SetValue("DisablePagingExecutive", 1);
            dontUnloadRAMDriver.Close();
        }
        
        /// <summary>
        /// Не выгружать из оперативной памяти коды ядра
        /// </summary>
        public void DontUnloadRAMCode()
        {
            RegistryKey dontUnloadRAM = Registry.LocalMachine.OpenSubKey(@"\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", true);
            dontUnloadRAM.SetValue("LargeSystemCache", 1);
            dontUnloadRAM.Close();
        }

        /// <summary>
        /// Очищение файла подкачки при выключении компьютера
        /// </summary>
        public void ClearPageFileAtShutdown()
        {
            RegistryKey clearPageFile = Registry.LocalMachine.OpenSubKey(@"\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", true);
            clearPageFile.SetValue("ClearPageFileAtShutdown", 1);
            clearPageFile.Close();
        }

        /// <summary>
        /// Быстрое выключение компьютера
        /// </summary>
        public void KillServiceTimeout ()
        {
            RegistryKey controlSet001 = Registry.LocalMachine.OpenSubKey(@"\SYSTEM\ControlSet001\Control", true);
            controlSet001.SetValue("WaitToKillServiceTimeout", 12000); // Устанавливаем на 12 секунд.
            controlSet001.Close();

            RegistryKey controlSet002 = Registry.LocalMachine.OpenSubKey(@"\SYSTEM\ControlSet002\Control", true);
            controlSet002.SetValue("WaitToKillServiceTimeout", 12000); // Устанавливаем на 12 секунд.
            controlSet002.Close();

            RegistryKey currentControlSet = Registry.LocalMachine.OpenSubKey(@"\SYSTEM\CurrentControlSet\Control", true);
            currentControlSet.SetValue("WaitToKillServiceTimeout", 12000); // Устанавливаем на 12 секунд.
            currentControlSet.Close();
        }

        /// <summary>
        /// Отключение кэширование изображений
        /// </summary>
        public void DisableThumbailCache()
        {
            RegistryKey disableThumbailCache = Registry.CurrentUser.OpenSubKey(@"\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
            disableThumbailCache.SetValue("DisableThumbailCache", 1, RegistryValueKind.DWord);
            disableThumbailCache.Close();
        }

        /// <summary>
        /// Отключение автозапуска для CD/DVD дисков
        /// </summary>
        public void DisableAutoRunCD()
        {
            RegistryKey disableAutoRun = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\services\cdrom", true);
            disableAutoRun.SetValue("AutoRun", 0);
            disableAutoRun.Close();
        }

        /// <summary>
        /// Отключение автоматического обновления Windows
        /// </summary>
        public void DisableAutoUpdate()
        {
            RegistryKey disableAutoUpdate = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update", true);
            disableAutoUpdate.SetValue("AUOptions", 1);
            disableAutoUpdate.Close();
        }

        /// <summary>
        /// Ускорение открытия меню "Пуск"
        /// </summary>
        public void SpeedStart()
        {
            RegistryKey speedStart = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            speedStart.SetValue("MenuShowDelay", 150);
            speedStart.Close();
        }

        /// <summary>
        /// Отключение истории списка последних документов
        /// </summary>
        public void DisableHistoryLastDocs ()
        {
            RegistryKey disableHistoryLastDocs = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true);
            disableHistoryLastDocs.SetValue("NoRecentDocsHistory", 1, RegistryValueKind.DWord);
            disableHistoryLastDocs.Close();
        }

        /// <summary>
        /// Повышение производительности NTFS
        /// </summary>
        public void UpSpeedNTFS()
        {
            // Отключает запись последнего времени доступа к файлу.
            RegistryKey NtfsDisableLastAccessUpdate = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\FileSystem", true);
            NtfsDisableLastAccessUpdate.SetValue("NtfsDisableLastAccessUpdate", 1);
            NtfsDisableLastAccessUpdate.Close();

            // Отключает создание специальной таблицы файлов для имени в формате MS-DOS.
            RegistryKey NtfsDisable8dot3NameCreation = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\FileSystem", true);
            NtfsDisable8dot3NameCreation.SetValue("NtfsDisable8dot3NameCreation", 1);
            NtfsDisable8dot3NameCreation.Close();
        }

        /// <summary>
        /// Повышение приоритета активным приложениям
        /// </summary>
        public void UpPrioritySeparation()
        {
            RegistryKey upPrioritySeparation = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\PriorityControl", true);
            upPrioritySeparation.SetValue("Win32PrioritySeparation", 6);
            upPrioritySeparation.Close();
        }

        /// <summary>
        /// Отключение всплывающих подсказок для элементов рабочего стола
        /// </summary>
        public void DisableShowInfoTip()
        {
            RegistryKey disableShotInfoTip = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
            disableShotInfoTip.SetValue("ShotInfoTip", 0);
            disableShotInfoTip.Close();
        }
    }
}
