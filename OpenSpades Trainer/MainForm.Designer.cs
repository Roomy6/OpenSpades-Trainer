namespace OpenSpades_Trainer
{
    partial class MainForm
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
            this.UnlimAmmoChk = new System.Windows.Forms.CheckBox();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ZPosTextBx = new System.Windows.Forms.TextBox();
            this.XPosTextBx = new System.Windows.Forms.TextBox();
            this.YPosTextBx = new System.Windows.Forms.TextBox();
            this.XPosBtn = new System.Windows.Forms.Button();
            this.YPosBtn = new System.Windows.Forms.Button();
            this.ZPosBtn = new System.Windows.Forms.Button();
            this.PosManipChk = new System.Windows.Forms.CheckBox();
            this.AllPosBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomFOVChk = new System.Windows.Forms.CheckBox();
            this.FOVTextBx = new System.Windows.Forms.TextBox();
            this.OverlayChk = new System.Windows.Forms.CheckBox();
            this.GodJumpChk = new System.Windows.Forms.CheckBox();
            this.FastToolSwitchChk = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UnlimAmmoChk
            // 
            this.UnlimAmmoChk.AutoSize = true;
            this.UnlimAmmoChk.ForeColor = System.Drawing.Color.White;
            this.UnlimAmmoChk.Location = new System.Drawing.Point(35, 54);
            this.UnlimAmmoChk.Name = "UnlimAmmoChk";
            this.UnlimAmmoChk.Size = new System.Drawing.Size(101, 17);
            this.UnlimAmmoChk.TabIndex = 0;
            this.UnlimAmmoChk.Text = "Unlimited Ammo";
            this.UnlimAmmoChk.UseVisualStyleBackColor = true;
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process:";
            // 
            // ProcOpenLbl
            // 
            this.ProcOpenLbl.AutoSize = true;
            this.ProcOpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ProcOpenLbl.ForeColor = System.Drawing.Color.Red;
            this.ProcOpenLbl.Location = new System.Drawing.Point(57, 9);
            this.ProcOpenLbl.Name = "ProcOpenLbl";
            this.ProcOpenLbl.Size = new System.Drawing.Size(106, 13);
            this.ProcOpenLbl.TabIndex = 2;
            this.ProcOpenLbl.Text = "Game Not Found!";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorLbl.Location = new System.Drawing.Point(387, 239);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(85, 13);
            this.authorLbl.TabIndex = 3;
            this.authorLbl.Text = "Made By Roomy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hacks:";
            // 
            // ZPosTextBx
            // 
            this.ZPosTextBx.Location = new System.Drawing.Point(411, 9);
            this.ZPosTextBx.Name = "ZPosTextBx";
            this.ZPosTextBx.Size = new System.Drawing.Size(61, 20);
            this.ZPosTextBx.TabIndex = 7;
            this.ZPosTextBx.Text = "Z";
            this.ZPosTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XPosTextBx
            // 
            this.XPosTextBx.Location = new System.Drawing.Point(277, 9);
            this.XPosTextBx.Name = "XPosTextBx";
            this.XPosTextBx.Size = new System.Drawing.Size(61, 20);
            this.XPosTextBx.TabIndex = 8;
            this.XPosTextBx.Text = "X";
            this.XPosTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YPosTextBx
            // 
            this.YPosTextBx.Location = new System.Drawing.Point(344, 9);
            this.YPosTextBx.Name = "YPosTextBx";
            this.YPosTextBx.Size = new System.Drawing.Size(61, 20);
            this.YPosTextBx.TabIndex = 9;
            this.YPosTextBx.Text = "Y";
            this.YPosTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XPosBtn
            // 
            this.XPosBtn.Location = new System.Drawing.Point(277, 35);
            this.XPosBtn.Name = "XPosBtn";
            this.XPosBtn.Size = new System.Drawing.Size(61, 23);
            this.XPosBtn.TabIndex = 10;
            this.XPosBtn.Text = "X Send";
            this.XPosBtn.UseVisualStyleBackColor = true;
            // 
            // YPosBtn
            // 
            this.YPosBtn.Location = new System.Drawing.Point(344, 35);
            this.YPosBtn.Name = "YPosBtn";
            this.YPosBtn.Size = new System.Drawing.Size(61, 23);
            this.YPosBtn.TabIndex = 11;
            this.YPosBtn.Text = "Y Send";
            this.YPosBtn.UseVisualStyleBackColor = true;
            this.YPosBtn.Click += new System.EventHandler(this.YPosBtn_Click);
            // 
            // ZPosBtn
            // 
            this.ZPosBtn.Location = new System.Drawing.Point(411, 35);
            this.ZPosBtn.Name = "ZPosBtn";
            this.ZPosBtn.Size = new System.Drawing.Size(61, 23);
            this.ZPosBtn.TabIndex = 12;
            this.ZPosBtn.Text = "Z Send";
            this.ZPosBtn.UseVisualStyleBackColor = true;
            // 
            // PosManipChk
            // 
            this.PosManipChk.AutoSize = true;
            this.PosManipChk.ForeColor = System.Drawing.Color.Gray;
            this.PosManipChk.Location = new System.Drawing.Point(35, 77);
            this.PosManipChk.Name = "PosManipChk";
            this.PosManipChk.Size = new System.Drawing.Size(126, 17);
            this.PosManipChk.TabIndex = 13;
            this.PosManipChk.Text = "Position Manipulation";
            this.PosManipChk.UseVisualStyleBackColor = true;
            // 
            // AllPosBtn
            // 
            this.AllPosBtn.Location = new System.Drawing.Point(344, 64);
            this.AllPosBtn.Name = "AllPosBtn";
            this.AllPosBtn.Size = new System.Drawing.Size(61, 23);
            this.AllPosBtn.TabIndex = 14;
            this.AllPosBtn.Text = "Send All";
            this.AllPosBtn.UseVisualStyleBackColor = true;
            this.AllPosBtn.Click += new System.EventHandler(this.AllPosBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomFOVChk
            // 
            this.CustomFOVChk.AutoSize = true;
            this.CustomFOVChk.ForeColor = System.Drawing.Color.White;
            this.CustomFOVChk.Location = new System.Drawing.Point(35, 100);
            this.CustomFOVChk.Name = "CustomFOVChk";
            this.CustomFOVChk.Size = new System.Drawing.Size(85, 17);
            this.CustomFOVChk.TabIndex = 16;
            this.CustomFOVChk.Text = "Custom FOV";
            this.CustomFOVChk.UseVisualStyleBackColor = true;
            // 
            // FOVTextBx
            // 
            this.FOVTextBx.Location = new System.Drawing.Point(126, 97);
            this.FOVTextBx.Name = "FOVTextBx";
            this.FOVTextBx.Size = new System.Drawing.Size(35, 20);
            this.FOVTextBx.TabIndex = 17;
            this.FOVTextBx.Text = "80";
            this.FOVTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OverlayChk
            // 
            this.OverlayChk.AutoSize = true;
            this.OverlayChk.ForeColor = System.Drawing.Color.White;
            this.OverlayChk.Location = new System.Drawing.Point(12, 206);
            this.OverlayChk.Name = "OverlayChk";
            this.OverlayChk.Size = new System.Drawing.Size(92, 17);
            this.OverlayChk.TabIndex = 18;
            this.OverlayChk.Text = "Show Overlay";
            this.OverlayChk.UseVisualStyleBackColor = true;
            this.OverlayChk.CheckedChanged += new System.EventHandler(this.OverlayChk_CheckedChanged);
            // 
            // GodJumpChk
            // 
            this.GodJumpChk.AutoSize = true;
            this.GodJumpChk.ForeColor = System.Drawing.Color.Gray;
            this.GodJumpChk.Location = new System.Drawing.Point(35, 123);
            this.GodJumpChk.Name = "GodJumpChk";
            this.GodJumpChk.Size = new System.Drawing.Size(74, 17);
            this.GodJumpChk.TabIndex = 19;
            this.GodJumpChk.Text = "God Jump";
            this.GodJumpChk.UseVisualStyleBackColor = true;
            // 
            // FastToolSwitchChk
            // 
            this.FastToolSwitchChk.AutoSize = true;
            this.FastToolSwitchChk.ForeColor = System.Drawing.Color.Gray;
            this.FastToolSwitchChk.Location = new System.Drawing.Point(35, 146);
            this.FastToolSwitchChk.Name = "FastToolSwitchChk";
            this.FastToolSwitchChk.Size = new System.Drawing.Size(105, 17);
            this.FastToolSwitchChk.TabIndex = 20;
            this.FastToolSwitchChk.Text = "Fast Tool Switch";
            this.FastToolSwitchChk.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.FastToolSwitchChk);
            this.Controls.Add(this.GodJumpChk);
            this.Controls.Add(this.OverlayChk);
            this.Controls.Add(this.FOVTextBx);
            this.Controls.Add(this.CustomFOVChk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllPosBtn);
            this.Controls.Add(this.PosManipChk);
            this.Controls.Add(this.ZPosBtn);
            this.Controls.Add(this.YPosBtn);
            this.Controls.Add(this.XPosBtn);
            this.Controls.Add(this.YPosTextBx);
            this.Controls.Add(this.XPosTextBx);
            this.Controls.Add(this.ZPosTextBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.ProcOpenLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnlimAmmoChk);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenSpades Trainer v0.0.6 x64";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UnlimAmmoChk;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcOpenLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ZPosTextBx;
        private System.Windows.Forms.TextBox XPosTextBx;
        private System.Windows.Forms.TextBox YPosTextBx;
        private System.Windows.Forms.Button XPosBtn;
        private System.Windows.Forms.Button YPosBtn;
        private System.Windows.Forms.Button ZPosBtn;
        private System.Windows.Forms.CheckBox PosManipChk;
        private System.Windows.Forms.Button AllPosBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CustomFOVChk;
        private System.Windows.Forms.TextBox FOVTextBx;
        private System.Windows.Forms.CheckBox OverlayChk;
        private System.Windows.Forms.CheckBox GodJumpChk;
        private System.Windows.Forms.CheckBox FastToolSwitchChk;
        private System.Windows.Forms.Timer timer1;
    }
}

