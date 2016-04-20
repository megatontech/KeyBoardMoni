namespace KeyBoardNotification
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.MoniSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.SoundSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.EffectSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelKeyCount = new DevExpress.XtraEditors.LabelControl();
            this.labelMouseCount = new DevExpress.XtraEditors.LabelControl();
            this.labelComboCount = new DevExpress.XtraEditors.LabelControl();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.minimalButton = new DevExpress.XtraEditors.SimpleButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MoniSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectSwitch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // MoniSwitch
            // 
            this.MoniSwitch.Location = new System.Drawing.Point(12, 12);
            this.MoniSwitch.Name = "MoniSwitch";
            this.MoniSwitch.Properties.OffText = "Off";
            this.MoniSwitch.Properties.OnText = "On";
            this.MoniSwitch.Size = new System.Drawing.Size(95, 23);
            this.MoniSwitch.TabIndex = 0;
            this.MoniSwitch.Toggled += new System.EventHandler(this.MoniSwitch_Toggled);
            // 
            // SoundSwitch
            // 
            this.SoundSwitch.Location = new System.Drawing.Point(12, 41);
            this.SoundSwitch.Name = "SoundSwitch";
            this.SoundSwitch.Properties.OffText = "Off";
            this.SoundSwitch.Properties.OnText = "On";
            this.SoundSwitch.Size = new System.Drawing.Size(95, 23);
            this.SoundSwitch.TabIndex = 1;
            this.SoundSwitch.Toggled += new System.EventHandler(this.SoundSwitch_Toggled);
            // 
            // EffectSwitch
            // 
            this.EffectSwitch.Location = new System.Drawing.Point(12, 70);
            this.EffectSwitch.Name = "EffectSwitch";
            this.EffectSwitch.Properties.OffText = "Off";
            this.EffectSwitch.Properties.OnText = "On";
            this.EffectSwitch.Size = new System.Drawing.Size(95, 23);
            this.EffectSwitch.TabIndex = 2;
            this.EffectSwitch.Toggled += new System.EventHandler(this.EffectSwitch_Toggled);
            // 
            // labelKeyCount
            // 
            this.labelKeyCount.Location = new System.Drawing.Point(158, 17);
            this.labelKeyCount.Name = "labelKeyCount";
            this.labelKeyCount.Size = new System.Drawing.Size(20, 14);
            this.labelKeyCount.TabIndex = 3;
            this.labelKeyCount.Text = "Key";
            // 
            // labelMouseCount
            // 
            this.labelMouseCount.Location = new System.Drawing.Point(158, 46);
            this.labelMouseCount.Name = "labelMouseCount";
            this.labelMouseCount.Size = new System.Drawing.Size(35, 14);
            this.labelMouseCount.TabIndex = 4;
            this.labelMouseCount.Text = "Mouse";
            // 
            // labelComboCount
            // 
            this.labelComboCount.Location = new System.Drawing.Point(158, 74);
            this.labelComboCount.Name = "labelComboCount";
            this.labelComboCount.Size = new System.Drawing.Size(28, 14);
            this.labelComboCount.TabIndex = 5;
            this.labelComboCount.Text = "Scroll";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(264, 11);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimalButton
            // 
            this.minimalButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.minimalButton.Location = new System.Drawing.Point(264, 65);
            this.minimalButton.Name = "minimalButton";
            this.minimalButton.Size = new System.Drawing.Size(24, 23);
            this.minimalButton.TabIndex = 8;
            this.minimalButton.Text = "-";
            this.minimalButton.Click += new System.EventHandler(this.minimalButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Moni";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.ControlBox = false;
            this.Controls.Add(this.minimalButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.labelComboCount);
            this.Controls.Add(this.labelMouseCount);
            this.Controls.Add(this.labelKeyCount);
            this.Controls.Add(this.EffectSwitch);
            this.Controls.Add(this.SoundSwitch);
            this.Controls.Add(this.MoniSwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Black";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miniBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.miniBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miniBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.MoniSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectSwitch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch MoniSwitch;
        private DevExpress.XtraEditors.ToggleSwitch SoundSwitch;
        private DevExpress.XtraEditors.ToggleSwitch EffectSwitch;
        private DevExpress.XtraEditors.LabelControl labelKeyCount;
        private DevExpress.XtraEditors.LabelControl labelMouseCount;
        private DevExpress.XtraEditors.LabelControl labelComboCount;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.SimpleButton minimalButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}