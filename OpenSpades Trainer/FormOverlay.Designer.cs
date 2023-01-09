namespace OpenSpades_Trainer
{
    partial class FormOverlay
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ylbl = new System.Windows.Forms.Label();
            this.Zlbl = new System.Windows.Forms.Label();
            this.Xlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z:";
            // 
            // Ylbl
            // 
            this.Ylbl.AutoSize = true;
            this.Ylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ylbl.ForeColor = System.Drawing.Color.White;
            this.Ylbl.Location = new System.Drawing.Point(100, 238);
            this.Ylbl.Name = "Ylbl";
            this.Ylbl.Size = new System.Drawing.Size(29, 15);
            this.Ylbl.TabIndex = 3;
            this.Ylbl.Text = "N/A";
            // 
            // Zlbl
            // 
            this.Zlbl.AutoSize = true;
            this.Zlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zlbl.ForeColor = System.Drawing.Color.White;
            this.Zlbl.Location = new System.Drawing.Point(161, 239);
            this.Zlbl.Name = "Zlbl";
            this.Zlbl.Size = new System.Drawing.Size(29, 15);
            this.Zlbl.TabIndex = 4;
            this.Zlbl.Text = "N/A";
            // 
            // Xlbl
            // 
            this.Xlbl.AutoSize = true;
            this.Xlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xlbl.ForeColor = System.Drawing.Color.White;
            this.Xlbl.Location = new System.Drawing.Point(38, 237);
            this.Xlbl.Name = "Xlbl";
            this.Xlbl.Size = new System.Drawing.Size(29, 15);
            this.Xlbl.TabIndex = 5;
            this.Xlbl.Text = "N/A";
            // 
            // FormOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.Xlbl);
            this.Controls.Add(this.Zlbl);
            this.Controls.Add(this.Ylbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOverlay";
            this.Text = "FormOverlay";
            this.Load += new System.EventHandler(this.FormOverlay_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormOverlay_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Ylbl;
        private System.Windows.Forms.Label Zlbl;
        private System.Windows.Forms.Label Xlbl;
    }
}