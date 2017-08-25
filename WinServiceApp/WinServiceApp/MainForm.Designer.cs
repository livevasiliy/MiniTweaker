namespace WinServiceApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceCheckbox = new System.Windows.Forms.CheckBox();
            this.ApplySettingsButton = new System.Windows.Forms.Button();
            this.DisableNetworkPrint_checkBox = new System.Windows.Forms.CheckBox();
            this.DontUnloadRAMCodeDriver_checkBox = new System.Windows.Forms.CheckBox();
            this.DontUnloadRAMCode_checkBox = new System.Windows.Forms.CheckBox();
            this.ClearPageFileAtShutdown_checkBox = new System.Windows.Forms.CheckBox();
            this.DisableAutoUpdate_checkBox = new System.Windows.Forms.CheckBox();
            this.DisableAutoRunCD_checkBox = new System.Windows.Forms.CheckBox();
            this.DisableThumbailCache_checkBox = new System.Windows.Forms.CheckBox();
            this.KillServiceTimeout_checkBox = new System.Windows.Forms.CheckBox();
            this.UpSpeedNTFS_checkBox = new System.Windows.Forms.CheckBox();
            this.DisableHistoryLastDocs_checkBox = new System.Windows.Forms.CheckBox();
            this.SpeedStart_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisableShowInfoTip_checkBox = new System.Windows.Forms.CheckBox();
            this.UpPrioritySeparation_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutAs = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceCheckbox
            // 
            this.serviceCheckbox.AutoSize = true;
            this.serviceCheckbox.Location = new System.Drawing.Point(6, 19);
            this.serviceCheckbox.Name = "serviceCheckbox";
            this.serviceCheckbox.Size = new System.Drawing.Size(216, 17);
            this.serviceCheckbox.TabIndex = 0;
            this.serviceCheckbox.Text = "Отключить не используемые службы";
            this.serviceCheckbox.UseVisualStyleBackColor = true;
            // 
            // ApplySettingsButton
            // 
            this.ApplySettingsButton.Location = new System.Drawing.Point(457, 439);
            this.ApplySettingsButton.Name = "ApplySettingsButton";
            this.ApplySettingsButton.Size = new System.Drawing.Size(324, 64);
            this.ApplySettingsButton.TabIndex = 1;
            this.ApplySettingsButton.Text = "Применить";
            this.ApplySettingsButton.UseVisualStyleBackColor = true;
            this.ApplySettingsButton.Click += new System.EventHandler(this.ApplySettingsButton_Click);
            // 
            // DisableNetworkPrint_checkBox
            // 
            this.DisableNetworkPrint_checkBox.AutoSize = true;
            this.DisableNetworkPrint_checkBox.Location = new System.Drawing.Point(20, 19);
            this.DisableNetworkPrint_checkBox.Name = "DisableNetworkPrint_checkBox";
            this.DisableNetworkPrint_checkBox.Size = new System.Drawing.Size(215, 17);
            this.DisableNetworkPrint_checkBox.TabIndex = 2;
            this.DisableNetworkPrint_checkBox.Text = "Отключить поиск сетевых принтеров";
            this.DisableNetworkPrint_checkBox.UseVisualStyleBackColor = true;
            // 
            // DontUnloadRAMCodeDriver_checkBox
            // 
            this.DontUnloadRAMCodeDriver_checkBox.AutoSize = true;
            this.DontUnloadRAMCodeDriver_checkBox.Location = new System.Drawing.Point(20, 53);
            this.DontUnloadRAMCodeDriver_checkBox.Name = "DontUnloadRAMCodeDriver_checkBox";
            this.DontUnloadRAMCodeDriver_checkBox.Size = new System.Drawing.Size(298, 17);
            this.DontUnloadRAMCodeDriver_checkBox.TabIndex = 3;
            this.DontUnloadRAMCodeDriver_checkBox.Text = "Отключить выгрузку из памяти неиспользуемых DLL";
            this.DontUnloadRAMCodeDriver_checkBox.UseVisualStyleBackColor = true;
            // 
            // DontUnloadRAMCode_checkBox
            // 
            this.DontUnloadRAMCode_checkBox.AutoSize = true;
            this.DontUnloadRAMCode_checkBox.Location = new System.Drawing.Point(20, 85);
            this.DontUnloadRAMCode_checkBox.Name = "DontUnloadRAMCode_checkBox";
            this.DontUnloadRAMCode_checkBox.Size = new System.Drawing.Size(343, 17);
            this.DontUnloadRAMCode_checkBox.TabIndex = 4;
            this.DontUnloadRAMCode_checkBox.Text = "Не выгружать из оперативной памяти коды ядра и драйверов";
            this.DontUnloadRAMCode_checkBox.UseVisualStyleBackColor = true;
            // 
            // ClearPageFileAtShutdown_checkBox
            // 
            this.ClearPageFileAtShutdown_checkBox.AutoSize = true;
            this.ClearPageFileAtShutdown_checkBox.Location = new System.Drawing.Point(20, 122);
            this.ClearPageFileAtShutdown_checkBox.Name = "ClearPageFileAtShutdown_checkBox";
            this.ClearPageFileAtShutdown_checkBox.Size = new System.Drawing.Size(316, 17);
            this.ClearPageFileAtShutdown_checkBox.TabIndex = 5;
            this.ClearPageFileAtShutdown_checkBox.Text = "Очищение файла подкачки при выключении компьютера";
            this.ClearPageFileAtShutdown_checkBox.UseVisualStyleBackColor = true;
            // 
            // DisableAutoUpdate_checkBox
            // 
            this.DisableAutoUpdate_checkBox.AutoSize = true;
            this.DisableAutoUpdate_checkBox.Location = new System.Drawing.Point(20, 266);
            this.DisableAutoUpdate_checkBox.Name = "DisableAutoUpdate_checkBox";
            this.DisableAutoUpdate_checkBox.Size = new System.Drawing.Size(277, 17);
            this.DisableAutoUpdate_checkBox.TabIndex = 9;
            this.DisableAutoUpdate_checkBox.Text = "Отключить автоматическое обновление Windows";
            this.DisableAutoUpdate_checkBox.UseVisualStyleBackColor = true;
            // 
            // DisableAutoRunCD_checkBox
            // 
            this.DisableAutoRunCD_checkBox.AutoSize = true;
            this.DisableAutoRunCD_checkBox.Location = new System.Drawing.Point(20, 231);
            this.DisableAutoRunCD_checkBox.Name = "DisableAutoRunCD_checkBox";
            this.DisableAutoRunCD_checkBox.Size = new System.Drawing.Size(254, 17);
            this.DisableAutoRunCD_checkBox.TabIndex = 8;
            this.DisableAutoRunCD_checkBox.Text = "Отключить автозапуска для CD/DVD дисков";
            this.DisableAutoRunCD_checkBox.UseVisualStyleBackColor = true;
            // 
            // DisableThumbailCache_checkBox
            // 
            this.DisableThumbailCache_checkBox.AutoSize = true;
            this.DisableThumbailCache_checkBox.Location = new System.Drawing.Point(20, 196);
            this.DisableThumbailCache_checkBox.Name = "DisableThumbailCache_checkBox";
            this.DisableThumbailCache_checkBox.Size = new System.Drawing.Size(223, 17);
            this.DisableThumbailCache_checkBox.TabIndex = 7;
            this.DisableThumbailCache_checkBox.Text = "Отключить кэширование изображений";
            this.DisableThumbailCache_checkBox.UseVisualStyleBackColor = true;
            // 
            // KillServiceTimeout_checkBox
            // 
            this.KillServiceTimeout_checkBox.AutoSize = true;
            this.KillServiceTimeout_checkBox.Location = new System.Drawing.Point(20, 159);
            this.KillServiceTimeout_checkBox.Name = "KillServiceTimeout_checkBox";
            this.KillServiceTimeout_checkBox.Size = new System.Drawing.Size(202, 17);
            this.KillServiceTimeout_checkBox.TabIndex = 6;
            this.KillServiceTimeout_checkBox.Text = "Быстрое выключение компьютера";
            this.KillServiceTimeout_checkBox.UseVisualStyleBackColor = true;
            // 
            // UpSpeedNTFS_checkBox
            // 
            this.UpSpeedNTFS_checkBox.AutoSize = true;
            this.UpSpeedNTFS_checkBox.Location = new System.Drawing.Point(20, 374);
            this.UpSpeedNTFS_checkBox.Name = "UpSpeedNTFS_checkBox";
            this.UpSpeedNTFS_checkBox.Size = new System.Drawing.Size(217, 17);
            this.UpSpeedNTFS_checkBox.TabIndex = 12;
            this.UpSpeedNTFS_checkBox.Text = "Повысить производительность NTFS";
            this.UpSpeedNTFS_checkBox.UseVisualStyleBackColor = true;
            // 
            // DisableHistoryLastDocs_checkBox
            // 
            this.DisableHistoryLastDocs_checkBox.AutoSize = true;
            this.DisableHistoryLastDocs_checkBox.Location = new System.Drawing.Point(20, 337);
            this.DisableHistoryLastDocs_checkBox.Name = "DisableHistoryLastDocs_checkBox";
            this.DisableHistoryLastDocs_checkBox.Size = new System.Drawing.Size(290, 17);
            this.DisableHistoryLastDocs_checkBox.TabIndex = 11;
            this.DisableHistoryLastDocs_checkBox.Text = "Отключение истории списка последних документов";
            this.DisableHistoryLastDocs_checkBox.UseVisualStyleBackColor = true;
            // 
            // SpeedStart_checkBox
            // 
            this.SpeedStart_checkBox.AutoSize = true;
            this.SpeedStart_checkBox.Location = new System.Drawing.Point(20, 302);
            this.SpeedStart_checkBox.Name = "SpeedStart_checkBox";
            this.SpeedStart_checkBox.Size = new System.Drawing.Size(195, 17);
            this.SpeedStart_checkBox.TabIndex = 10;
            this.SpeedStart_checkBox.Text = "Ускорить открытие меню \"Пуск\"";
            this.SpeedStart_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.DisableShowInfoTip_checkBox);
            this.groupBox1.Controls.Add(this.UpPrioritySeparation_checkBox);
            this.groupBox1.Controls.Add(this.DisableNetworkPrint_checkBox);
            this.groupBox1.Controls.Add(this.DontUnloadRAMCodeDriver_checkBox);
            this.groupBox1.Controls.Add(this.DontUnloadRAMCode_checkBox);
            this.groupBox1.Controls.Add(this.ClearPageFileAtShutdown_checkBox);
            this.groupBox1.Controls.Add(this.KillServiceTimeout_checkBox);
            this.groupBox1.Controls.Add(this.DisableThumbailCache_checkBox);
            this.groupBox1.Controls.Add(this.DisableAutoRunCD_checkBox);
            this.groupBox1.Controls.Add(this.DisableAutoUpdate_checkBox);
            this.groupBox1.Controls.Add(this.SpeedStart_checkBox);
            this.groupBox1.Controls.Add(this.DisableHistoryLastDocs_checkBox);
            this.groupBox1.Controls.Add(this.UpSpeedNTFS_checkBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 476);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки реестра";
            // 
            // DisableShowInfoTip_checkBox
            // 
            this.DisableShowInfoTip_checkBox.AutoSize = true;
            this.DisableShowInfoTip_checkBox.Location = new System.Drawing.Point(20, 440);
            this.DisableShowInfoTip_checkBox.Name = "DisableShowInfoTip_checkBox";
            this.DisableShowInfoTip_checkBox.Size = new System.Drawing.Size(373, 17);
            this.DisableShowInfoTip_checkBox.TabIndex = 14;
            this.DisableShowInfoTip_checkBox.Text = "Отключить всплывающих подсказок для элементов рабочего стола";
            this.DisableShowInfoTip_checkBox.UseVisualStyleBackColor = true;
            // 
            // UpPrioritySeparation_checkBox
            // 
            this.UpPrioritySeparation_checkBox.AutoSize = true;
            this.UpPrioritySeparation_checkBox.Location = new System.Drawing.Point(20, 407);
            this.UpPrioritySeparation_checkBox.Name = "UpPrioritySeparation_checkBox";
            this.UpPrioritySeparation_checkBox.Size = new System.Drawing.Size(259, 17);
            this.UpPrioritySeparation_checkBox.TabIndex = 13;
            this.UpPrioritySeparation_checkBox.Text = "Повысить приоритет активным приложением";
            this.UpPrioritySeparation_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(457, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 406);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основные настройки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutAs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutAs
            // 
            this.AboutAs.Name = "AboutAs";
            this.AboutAs.Size = new System.Drawing.Size(83, 20);
            this.AboutAs.Text = "О программе";
            this.AboutAs.Click += new System.EventHandler(this.AboutAs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ApplySettingsButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(801, 543);
            this.MinimumSize = new System.Drawing.Size(801, 543);
            this.Name = "MainForm";
            this.Text = "MiniTweaker ver 0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox serviceCheckbox;
        private System.Windows.Forms.Button ApplySettingsButton;
        private System.Windows.Forms.CheckBox DisableNetworkPrint_checkBox;
        private System.Windows.Forms.CheckBox DontUnloadRAMCodeDriver_checkBox;
        private System.Windows.Forms.CheckBox DontUnloadRAMCode_checkBox;
        private System.Windows.Forms.CheckBox ClearPageFileAtShutdown_checkBox;
        private System.Windows.Forms.CheckBox DisableAutoUpdate_checkBox;
        private System.Windows.Forms.CheckBox DisableAutoRunCD_checkBox;
        private System.Windows.Forms.CheckBox DisableThumbailCache_checkBox;
        private System.Windows.Forms.CheckBox KillServiceTimeout_checkBox;
        private System.Windows.Forms.CheckBox UpSpeedNTFS_checkBox;
        private System.Windows.Forms.CheckBox DisableHistoryLastDocs_checkBox;
        private System.Windows.Forms.CheckBox SpeedStart_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox UpPrioritySeparation_checkBox;
        private System.Windows.Forms.CheckBox DisableShowInfoTip_checkBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutAs;
    }
}

