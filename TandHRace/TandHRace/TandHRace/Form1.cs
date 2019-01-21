using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TandHRace
{
    public partial class Form1 : Form
    {
        Statistics Stats = new Statistics();
        Race MainRace;
        bool Running = false;
        int speed=5;
        bool drawPic = false;
        Dictionary<int, int> Speeds = new Dictionary<int, int>
        {
            [0] = 4500,
            [1] = 4000,
            [2] = 3500,
            [3] = 3000,
            [4] = 2500,
            [5] = 2000,
            [6] = 1500,
            [7] = 1000,
            [8] = 750,
            [9] = 500,
            [10] = 250
        };

        public Form1()
        {
            InitializeComponent();
            Race.GameOver += this.GameEnd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instantiate the race
            MainRace = new Race((int)nudSteps.Value, Speeds[speed], pbHare.Width, pbHare.Height);
            MainTimer.Interval = MainRace.GameSpeed;
            MainTimer.Start();
        }
        
        private void GameEnd(string wintype)
        {
            string modifier = "";

            //Increment the appropriate stats
            switch (wintype)
            {
                case "DRAW":
                    Stats.Draws++;
                    break;
                case "HARE WIN":
                    Stats.HareWins++;
                    modifier = ", YUCK";
                    break;
                case "TURTLE WIN":
                    Stats.TurtleWins++;
                    modifier = ", HOORAY!";
                    break;
                default:
                    break;
            }
            MainTimer.Stop();
            MessageBox.Show(wintype + modifier);

            txtHareWins.Text = Stats.Display()["HARE WIN"].ToString();
            txtTortoiseWins.Text = Stats.Display()["TURTLE WIN"].ToString();
            txtDraw.Text = Stats.Display()["DRAWS"].ToString();
            Stats.SaveStatistics();

            btnReset.PerformClick();
            btnStartPause.PerformClick();
        }

        private void btnHareColor_Click(object sender, EventArgs e)
        {
            if (cdHareColor.ShowDialog() == DialogResult.OK)
            {
                MainRace.SetHareColor(cdHareColor.Color);
            }
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            //Negate the running bool
            Running = !Running;
            if (Running)
            {
                MainTimer.Start();
                btnStartPause.Text = "❚❚";
            }
            if (!Running)
            {
                MainTimer.Stop();
                btnStartPause.Text = "▶";
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            //Make a new game and pause it
            MainRace = new Race((int)nudSteps.Value, Speeds[speed], pbHare.Width, pbHare.Height);
            MainTimer.Interval = MainRace.GameSpeed;
            if(Running)
                btnStartPause.PerformClick();
            pbHare.Invalidate();
            pbTurtle.Invalidate();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (Running)
            {
                //Update the race and redraw
                MainRace.Update();
                pbHare.Invalidate();
                pbTurtle.Invalidate();
            }
        }

        private void pbTurtle_Paint(object sender, PaintEventArgs e)
        {
            //Draw the turtle
            if (drawPic)
            {
                MainRace.Turtle.DrawPic(e.Graphics, MainRace);
            }
            else
            {
                MainRace.Turtle.Draw(e.Graphics, MainRace);
            }
        }

        private void pbHare_Paint(object sender, PaintEventArgs e)
        {
            //Draw the hare
            if (drawPic)
            {
                //MainRace.Hare.DrawPic(e.Graphics, MainRace);
            }
            else
            {
                MainRace.Hare.Draw(e.Graphics, MainRace);
            }
        }

        private void btnIncreaseTimer_Click(object sender, EventArgs e)
        {
            if (speed+1 >= Speeds.Count())
            {
                return;
            }
            else
            {
                speed++;
                MainRace.GameSpeed = Speeds[speed];
                MainTimer.Interval = MainRace.GameSpeed;
            }
        }

        private void btnSlowTimer_Click(object sender, EventArgs e)
        {
            if (speed <= 0)
            {
                return;
            }
            else
            {
                speed--;
                MainRace.GameSpeed = Speeds[speed];
                MainTimer.Interval = MainRace.GameSpeed;
            }
        }

        private void bntTortoiseColor_Click(object sender, EventArgs e)
        {
            if(cdTurtleColor.ShowDialog() == DialogResult.OK)
            {
                MainRace.SetTurtleColor(cdTurtleColor.Color);
            }
        }

        private void rbPictureMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPictureMode.Checked)
            {
                drawPic = true;
            }
            else
            {
                drawPic = false;
            }
        }
    }
}