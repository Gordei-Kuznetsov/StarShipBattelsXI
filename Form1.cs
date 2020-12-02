using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarShipBattelsXI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
        void DisableLabels ()
        {
            StartLabel.Visible = false;
            ModeLabel.Visible = false;
            ControlsLabel.Visible = false;
            ExitLabel.Visible = false;
            HighestScoreLabel.Visible = false;
            StartLabel.Enabled = false;
            ModeLabel.Enabled = false;
            ControlsLabel.Enabled = false;
            ExitLabel.Enabled = false;
            HighestScoreLabel.Enabled = false;
        }
        void EnableLabels()
        {
            StartLabel.Visible = true;
            ModeLabel.Visible = true;
            ControlsLabel.Visible = true;
            ExitLabel.Visible = true;
            HighestScoreLabel.Visible = true;
            StartLabel.Enabled = true;
            ModeLabel.Enabled = true;
            ControlsLabel.Enabled = true;
            ExitLabel.Enabled = true;
            HighestScoreLabel.Enabled = true;
        }
        int highestScore = -1;

        //events for button animations
        private void StartLabel_MouseEnter(object sender, EventArgs e)
        {
            StartLabel.Font = new Font(StartLabel.Font, FontStyle.Bold);
        }

        private void StartLabel_MouseLeave(object sender, EventArgs e)
        {
            StartLabel.Font = new Font(StartLabel.Font, FontStyle.Regular);
        }

        private void ModeLabel_MouseEnter(object sender, EventArgs e)
        {
            ModeLabel.Font = new Font(ModeLabel.Font, FontStyle.Bold);
        }

        private void ModeLabel_MouseLeave(object sender, EventArgs e)
        {
            ModeLabel.Font = new Font(ModeLabel.Font, FontStyle.Regular);
        }

        private void ControlLabel_MouseEnter(object sender, EventArgs e)
        {
            ControlsLabel.Font = new Font(ControlsLabel.Font, FontStyle.Bold);
        }

        private void ControlLabel_MouseLeave(object sender, EventArgs e)
        {
            ControlsLabel.Font = new Font(ControlsLabel.Font, FontStyle.Regular);
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.Font = new Font(ExitLabel.Font, FontStyle.Bold);
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.Font = new Font(ExitLabel.Font, FontStyle.Regular);
        }

        private void EasyLabel_MouseEnter(object sender, EventArgs e)
        {
            EasyLabel.Font = new Font(EasyLabel.Font, FontStyle.Bold);
        }

        private void EasyLabel_MouseLeave(object sender, EventArgs e)
        {
            EasyLabel.Font = new Font(EasyLabel.Font, FontStyle.Regular);
        }

        private void MediumLabel_MouseEnter(object sender, EventArgs e)
        {
            MediumLabel.Font = new Font(MediumLabel.Font, FontStyle.Bold);
        }

        private void MediumLabel_MouseLeave(object sender, EventArgs e)
        {
            MediumLabel.Font = new Font(MediumLabel.Font, FontStyle.Regular);
        }

        private void HardLabel_MouseEnter(object sender, EventArgs e)
        {
            HardLabel.Font = new Font(HardLabel.Font, FontStyle.Bold);
        }

        private void HardLabel_MouseLeave(object sender, EventArgs e)
        {
            HardLabel.Font = new Font(HardLabel.Font, FontStyle.Regular);
        }

        private void OKLabel_MouseEnter(object sender, EventArgs e)
        {
            OKLabel.Font = new Font(OKLabel.Font, FontStyle.Bold);
        }

        private void OKLabel_MouseLeave(object sender, EventArgs e)
        {
            OKLabel.Font = new Font(OKLabel.Font, FontStyle.Regular);
        }

        public int mode = 0;
        private void StartLabel_Click(object sender, EventArgs e) //staring the game
        {
            DisableLabels();
            MainLabel.Visible = false;
            this.ShowInTaskbar = false;
            starFieldBackgroundPictureBox.BringToFront();
            starFieldBackgroundPictureBox.Visible = true;
            Form2 form2 = new Form2(this, mode);
            form2.ShowDialog();
            EnableLabels();
            if (highestScore < form2.score)
            {
                highestScore = form2.score;
                HighestScoreLabel.Text = $"HIGHEST SCORE\n\rSO FAR\n\r{highestScore}";
            }

            MainLabel.Visible = true;
            starFieldBackgroundPictureBox.SendToBack();
            starFieldBackgroundPictureBox.Visible = false;
        }

        private void ModeLabel_Click(object sender, EventArgs e)
        {
            DisableLabels();
            EasyLabel.Visible = true;
            MediumLabel.Visible = true;
            HardLabel.Visible = true;
            EasyLabel.Enabled = true;
            MediumLabel.Enabled = true;
            HardLabel.Enabled = true;
        }

        private void EasyLabel_Click(object sender, EventArgs e)
        {
            EnableLabels();
            EasyLabel.Visible = false;
            MediumLabel.Visible = false;
            HardLabel.Visible = false;
            EasyLabel.Enabled = false;
            MediumLabel.Enabled = false;
            HardLabel.Enabled = false;
        }

        private void MediumLabel_Click(object sender, EventArgs e)
        {
            mode = 2;
            EnableLabels();
            EasyLabel.Visible = false;
            MediumLabel.Visible = false;
            HardLabel.Visible = false;
            EasyLabel.Enabled = false;
            MediumLabel.Enabled = false;
            HardLabel.Enabled = false;
        }

        private void HardLabel_Click(object sender, EventArgs e)
        {
            mode = 4;
            EnableLabels();
            EasyLabel.Visible = false;
            MediumLabel.Visible = false;
            HardLabel.Visible = false;
            EasyLabel.Enabled = false;
            MediumLabel.Enabled = false;
            HardLabel.Enabled = false;
        }

        private void ControlLabel_Click(object sender, EventArgs e)
        {
            DisableLabels();
            ControlDescriptionLabel.Visible = true;
            OKLabel.Visible = true;
            ControlDescriptionLabel.Enabled = true;
            OKLabel.Enabled = true;
        }

        private void OKLabel_Click(object sender, EventArgs e)
        {
            ControlDescriptionLabel.Visible = false;
            OKLabel.Visible = false;
            ControlDescriptionLabel.Enabled = false;
            OKLabel.Enabled = false;
            EnableLabels();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int fontLength1 = Properties.Resources._3D_Thirteen_Pixel_Fonts.Length;
            byte[] fontdata1 = Properties.Resources._3D_Thirteen_Pixel_Fonts;
            System.IntPtr data1 = Marshal.AllocCoTaskMem(fontLength1);
            Marshal.Copy(fontdata1, 0, data1, fontLength1);
            pfc.AddMemoryFont(data1, fontLength1);

            int fontLength2 = Properties.Resources._04B_19___ttf.Length;
            byte[] fontData2 = Properties.Resources._04B_19___ttf;
            System.IntPtr data2 = Marshal.AllocCoTaskMem(fontLength2);
            Marshal.Copy(fontData2, 0, data2, fontLength2);
            pfc.AddMemoryFont(data2, fontLength2);

            MainLabel.Font = new Font(pfc.Families[0], MainLabel.Font.Size);
            ControlDescriptionLabel.Font = new Font(pfc.Families[0], ControlDescriptionLabel.Font.Size);
            StartLabel.Font = new Font(pfc.Families[1], StartLabel.Font.Size);
            ModeLabel.Font = new Font(pfc.Families[1], ModeLabel.Font.Size);
            ControlsLabel.Font = new Font(pfc.Families[1], ControlsLabel.Font.Size);
            ExitLabel.Font = new Font(pfc.Families[1], ExitLabel.Font.Size);
            EasyLabel.Font = new Font(pfc.Families[1], EasyLabel.Font.Size);
            MediumLabel.Font = new Font(pfc.Families[1], MediumLabel.Font.Size);
            HardLabel.Font = new Font(pfc.Families[1], HardLabel.Font.Size);
            OKLabel.Font = new Font(pfc.Families[1], OKLabel.Font.Size);
            HighestScoreLabel.Font = new Font(pfc.Families[0], HighestScoreLabel.Font.Size);
        }
    }
}
