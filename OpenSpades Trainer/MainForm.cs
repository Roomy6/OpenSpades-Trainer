using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace OpenSpades_Trainer
{
    public partial class MainForm : Form
    {
        FormOverlay frm = new FormOverlay();
        public Mem mem = new Mem();

        // Addresses

        string ammoAddr = "base+0x004E1920,18,AC,124,40,C,40,28";
        //string YPosAddr = "base+0x004F7218,C,C,14,10,50,80,94,0,4";
        string FOVAddr = "base+0x004E0CE8,30";

        string XPosAddr = "046016DC";
        string YPosAddr = "040E4614";
        string ZPosAddr = "046016E4";

        public MainForm()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void OverlayChk_CheckedChanged(object sender, EventArgs e)
        {
            if(OverlayChk.Checked == true)
            {
                frm.Show();
            }
            else
            {
                frm.Hide();
            }
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = mem.OpenProcess("OpenSpades");
            if (!ProcOpen)
            {
                //ProcOpen = false;
                Thread.Sleep(1000);
                return;
            }

            ProcOpen = true;

            Thread.Sleep(200);
            BGWorker.ReportProgress(0);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLbl.ForeColor = Color.Lime;  // Changes the colour if process is found
                ProcOpenLbl.Text = "Game Found!";
            }
            else
            {   // Not sure why this is not working.
                ProcOpenLbl.ForeColor = Color.Red;
                ProcOpenLbl.Text = "Game Not Found!";
                System.Console.WriteLine("Game Not Found!");
            }

            // Checks if Unlim Ammo is checked (this is here cus it will not update)
            if (UnlimAmmoChk.Checked == true)
            {
                // Ammo
                mem.WriteMemory(ammoAddr, "int", "5");
            }

            // Custom FOV for... custom FOV ?:D
            if (CustomFOVChk.Checked == true)
            {
                if (FOVTextBx.Text != "")
                {
                    mem.WriteMemory(FOVAddr, "float", FOVTextBx.Text);
                }
            }

        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void YPosBtn_Click(object sender, EventArgs e)
        {
            if (PosManipChk.Checked == true)
            {
                mem.WriteMemory(YPosAddr, "float", YPosTextBx.Text);    // Y Pos Only :( for now :D
            }
        }

        private void AllPosBtn_Click(object sender, EventArgs e)
        {
            if (PosManipChk.Checked == true)
            {
                mem.WriteMemory(XPosAddr, "float", XPosTextBx.Text);    // X Pos
                mem.WriteMemory(YPosAddr, "float", YPosTextBx.Text);    // Y Pos
                mem.WriteMemory(ZPosAddr, "float", ZPosTextBx.Text);    // Z Pos
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PosManipChk.Checked == true)
            {
                mem.WriteMemory(YPosAddr, "float", YPosTextBx.Text);
            }
        }
    }
}
