using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarShipBattelsXI
{
    public partial class Form2 : Form
    {
        Form1 f1; //reference to the first form
        readonly int mode;
        public Form2(Form1 form1, int a)
        {
            mode = a;
            f1 = form1;
            InitializeComponent();
            allTimedObjects = new List<PictureBox> { bossPictureBox, eagle1PictureBox, eagle2PictureBox, eagle3PictureBox, purpleBlastPictureBox, yellowCentralBlastPictureBox, yellowLeftBlastPictureBox, yellowRightBlastPictureBox };
            alldangerousObjects = new List<PictureBox> { bossPictureBox, eagle1PictureBox, eagle2PictureBox, eagle3PictureBox, yellowCentralBlastPictureBox, yellowLeftBlastPictureBox, yellowRightBlastPictureBox };
            thisFormBounds = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            scoreLabel.Font = new Font(f1.pfc.Families[0], scoreLabel.Font.Size);
            finalScoreSign.Font = new Font(f1.pfc.Families[0], finalScoreSign.Font.Size);
            ExitLabel.Font = new Font(f1.pfc.Families[1], ExitLabel.Font.Size);
            foreach (PictureBox obj in allTimedObjects) //changin speeds of objects
            {
                if (obj == purpleBlastPictureBox)
                {
                    obj.Tag = Convert.ToInt32(obj.Tag) - mode;
                }
                else
                {
                    obj.Tag = Convert.ToInt32(obj.Tag) + mode;
                }
            }
            starShipPictureBox.Tag = Convert.ToInt32(starShipPictureBox.Tag) + mode;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (PictureBox obj in allTimedObjects)
            {
                if (obj == purpleBlastPictureBox)
                {
                    obj.Tag = Convert.ToInt32(obj.Tag) + mode;
                }
                else
                {
                    obj.Tag = Convert.ToInt32(obj.Tag) - mode;
                }
            }
            starShipPictureBox.Tag = Convert.ToInt32(starShipPictureBox.Tag) - mode;
        }
        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.Font = new Font(ExitLabel.Font, FontStyle.Bold);
        }
        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.Font = new Font(ExitLabel.Font, FontStyle.Regular);
        }
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            f1.Size = Size;
        }
        private void Form2_Move(object sender, EventArgs e)
        {
            f1.Location = Location;
        }

        Rectangle thisFormBounds;
        public List<PictureBox> allTimedObjects;
        List<PictureBox> alldangerousObjects;
        Random x = new Random();
        Random y = new Random();
        public int score = 0;
        public bool gameEnded = false;
        public bool purpleBlastIsShot = false;
        public bool yellowBlastsAreShot = false;
        public bool yellowBlastIsShot = false;
        public bool purpleBlastIsIntersecting = false;

        Point NewLocation (PictureBox obj)
        {
            if (obj == bossPictureBox)
            {
                return new Point(x.Next(50, this.Width - 160), y.Next(-500, -200));
            }
            if ((obj == eagle1PictureBox) || (obj == eagle2PictureBox) || (obj == eagle3PictureBox))
            {
                return new Point(x.Next(30, this.Width - 100), y.Next(-200, -100));
            }
            if (obj == purpleBlastPictureBox)
            {
                return new Point(0, -100);
            }
            else
            {
                return new Point(0, -200);
            }
        }
        bool OutOfFormBOunds(PictureBox obj)
        {
            if (!obj.Bounds.IntersectsWith(thisFormBounds))
            {
                return true;
            }
            return false;
        }
        private void timer1_Tick(object sender, EventArgs e) //animation
        {
            foreach (PictureBox obj in allTimedObjects)
            {
                if (!OutOfFormBOunds(obj))
                {
                    if (obj == yellowLeftBlastPictureBox)
                    {
                        obj.Top += Convert.ToInt32(Convert.ToInt32(obj.Tag) * 3 / 4);
                        obj.Left -= Convert.ToInt32(Convert.ToInt32(obj.Tag) * 3 / 4);
                    }
                    else if (obj == yellowRightBlastPictureBox)
                    {
                        obj.Top += Convert.ToInt32(Convert.ToInt32(obj.Tag) * 3 / 4);
                        obj.Left += Convert.ToInt32(Convert.ToInt32(obj.Tag) * 3 / 4);
                    }
                    else
                    {
                        obj.Top += Convert.ToInt32(obj.Tag);
                    }
                }
                else
                {
                    if (obj.Location.Y >0)
                    {
                        obj.Location = NewLocation(obj);
                        if (obj == purpleBlastPictureBox)
                        {
                            purpleBlastIsShot = false;
                        }
                    }
                    if (obj.Bottom < this.Top)
                    {
                        if (obj == purpleBlastPictureBox)
                        {
                            purpleBlastIsShot = false;
                        }
                        else if (obj == yellowCentralBlastPictureBox)
                        {
                            yellowBlastIsShot = false;
                        }
                        else if (obj == yellowLeftBlastPictureBox)
                        {
                            if (OutOfFormBOunds(yellowRightBlastPictureBox))
                            {
                                yellowBlastsAreShot = false;
                            }
                        }
                        else if (obj == yellowRightBlastPictureBox)
                        {
                            if (OutOfFormBOunds(yellowLeftBlastPictureBox))
                            {
                                yellowBlastsAreShot = false;
                            }
                        }
                        else
                        {
                            obj.Top += Convert.ToInt32(obj.Tag);
                        }
                    }
                }
            }
        }

        int ticks = 0;
        private void timer2_Tick(object sender, EventArgs e) //animation
        {
            if ((ticks % 2 == 1) && !yellowBlastIsShot)
            {
                BlastShotAnimation(yellowCentralBlastPictureBox, bossPictureBox, 36, 107, Properties.Resources.yellowBlastShotFile160);
                yellowBlastIsShot = true;
            }
            else if ((ticks % 2 == 0) && !yellowBlastsAreShot)
            {
                BlastShotAnimation(yellowLeftBlastPictureBox, bossPictureBox, -7, 74, Properties.Resources.yellowBlastShotFile160);
                BlastShotAnimation(yellowRightBlastPictureBox, bossPictureBox, 81, 74, Properties.Resources.yellowBlastShotFile160);
                yellowBlastsAreShot = true;
            }
            ticks++;
        }

        private async void timer3_Tick(object sender, EventArgs e) //ending of the game
        {
            foreach (PictureBox dObj in alldangerousObjects)
            {
                if (dObj.Bounds.IntersectsWith(new Rectangle (starShipPictureBox.Location.X, starShipPictureBox.Location.Y, 84, 77)))
                {
                    gameEnded = true;
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    if (dObj == yellowCentralBlastPictureBox || dObj == yellowLeftBlastPictureBox || dObj == yellowRightBlastPictureBox)
                    {
                        BlastExplosionAnimation(dObj, Properties.Resources.yellowBlastExplosionFile360);
                        ShipExplosionAnimation(starShipPictureBox, Properties.Resources.bigExplosionFile640);
                    }
                    else if (dObj == bossPictureBox)
                    {
                        ShipExplosionAnimation(dObj, Properties.Resources.bigExplosionFile640);
                        ShipExplosionAnimation(starShipPictureBox, Properties.Resources.bigExplosionFile640);
                        score += 3;
                        scoreLabel.Text = $"SCORE: {score}";
                    }
                    else
                    {
                        ShipExplosionAnimation(dObj, Properties.Resources.exploshionFile640);
                        ShipExplosionAnimation(starShipPictureBox, Properties.Resources.bigExplosionFile640);
                        score += 1;
                        scoreLabel.Text = $"SCORE: {score}";
                    }
                    await Task.Delay(640);
                    gameOverSign.Visible = true;
                    for (int i = 0; i <= 6; i++)
                    {
                        await Task.Delay(80);
                        gameOverSign.Width *= 2;
                        gameOverSign.Height *= 2;
                        gameOverSign.Location = new Point(Convert.ToInt32(this.Width / 2) - Convert.ToInt32(gameOverSign.Width / 2), Convert.ToInt32(this.Height / 2) - Convert.ToInt32(gameOverSign.Height / 2) - 100);
                    }
                    await Task.Delay(80);
                    gameOverSign.Width = gameOverSign.Width / 10 * 15;
                    gameOverSign.Height = gameOverSign.Height / 10 * 15;
                    gameOverSign.Location = new Point(Convert.ToInt32(this.Width / 2) - Convert.ToInt32(gameOverSign.Width / 2), Convert.ToInt32(this.Height / 2) - Convert.ToInt32(gameOverSign.Height / 2) - 100);
                    finalScoreSign.Location = new Point(Convert.ToInt32(this.Width / 2) - 260, gameOverSign.Bottom + 10);
                    finalScoreSign.Text += score;
                    finalScoreSign.Visible = true;
                    ExitLabel.Enabled = true;
                    ExitLabel.Visible = true;
                    return;
                }
                else if (dObj.Bounds.IntersectsWith(new Rectangle (purpleBlastPictureBox.Location.X, purpleBlastPictureBox.Location.Y, 14, 24)) && purpleBlastIsIntersecting == false)
                {
                    purpleBlastIsIntersecting = true;
                    if (dObj == yellowCentralBlastPictureBox || dObj == yellowLeftBlastPictureBox || dObj == yellowRightBlastPictureBox)
                    {
                        BlastExplosionAnimation(purpleBlastPictureBox, Properties.Resources.bigExplosionFile640);
                        dObj.Location = NewLocation(dObj);
                    }
                    else if (dObj == bossPictureBox)
                    {
                        ShipExplosionAnimation(dObj, Properties.Resources.bigExplosionFile640);
                        BlastExplosionAnimation(purpleBlastPictureBox, Properties.Resources.purpleBlastExplosionFile360);
                        score += 3;
                        scoreLabel.Text = $"SCORE: {score}";
                    }
                    else
                    {
                        ShipExplosionAnimation(dObj, Properties.Resources.exploshionFile640);
                        BlastExplosionAnimation(purpleBlastPictureBox, Properties.Resources.purpleBlastExplosionFile360);
                        score += 1;
                        scoreLabel.Text = $"SCORE: {score}";
                    }
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e) //controlling the game
        {
            if (!gameEnded)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (starShipPictureBox.Left > 20)
                    {
                        starShipPictureBox.Left -= Convert.ToInt32(starShipPictureBox.Tag);
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (starShipPictureBox.Right < this.Width - 40)
                    {
                        starShipPictureBox.Left += Convert.ToInt32(starShipPictureBox.Tag);
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (starShipPictureBox.Top > this.Height - 428)
                    {
                        starShipPictureBox.Top -= Convert.ToInt32(starShipPictureBox.Tag) - 2;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (starShipPictureBox.Bottom < this.Height - 50)
                    {
                        starShipPictureBox.Top += Convert.ToInt32(starShipPictureBox.Tag) + 2;
                    }
                }
                if ((e.KeyCode == Keys.Space) && !purpleBlastIsShot)
                {
                    purpleBlastIsShot = true;
                    BlastShotAnimation(purpleBlastPictureBox, starShipPictureBox, 30, 5, Properties.Resources.purpleBlastShotFile160);
                }
            }
        }
        async void BlastShotAnimation(PictureBox blast, PictureBox parentBox, int X, int Y, Image imageFile)
        {
            int tag = Convert.ToInt32(blast.Tag);
            blast.Tag = 0;
            Image pic = blast.Image;
            Size size = blast.Size;
            blast.Size = new Size(24, 24);
            blast.Location = new Point(parentBox.Left + X, parentBox.Top + Y);
            blast.Image = imageFile;
            await Task.Delay(160);
            blast.Tag = tag;
            blast.Size = size;
            blast.Image = pic;
        }
        async void BlastExplosionAnimation(PictureBox blast, Image imageFile)
        {
            int tag = Convert.ToInt32(blast.Tag);
            blast.Tag = 0;
            Image pic = blast.Image;
            Size size = blast.Size;
            blast.Size = new Size(30, 45);
            blast.Image = imageFile;
            if (blast == purpleBlastPictureBox)
            {
                await Task.Delay(640);
            }
            else
            {
                await Task.Delay(360);
            }
            blast.Location = NewLocation(blast);
            blast.Tag = tag;
            blast.Size = size;
            blast.Image = pic;
            if (blast == purpleBlastPictureBox)
            {
                purpleBlastIsIntersecting = false;
            }
        }
        async void ShipExplosionAnimation(PictureBox ship, Image imageFile)
        {
            int tag = Convert.ToInt32(ship.Tag);
            ship.Tag = 0;
            Image pic = ship.Image;
            ship.Image = imageFile;
            await Task.Delay(640);
            ship.Location = NewLocation(ship);
            ship.Tag = tag;
            ship.Image = pic;
        }
    }
}
