using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TandHRace
{
    class Race
    {
        public delegate void GameOverEventHandler(string endType);
        public static event GameOverEventHandler GameOver;

        public Hare Hare = new Hare();
        public Turtle Turtle = new Turtle();
        public int GameSpeed, Steps, BoxSize, Height;

        public Race(int steps, int speed, Color HareColor, Color TortoiseColor, int width, int height)
        {
            //Set the speed and hare variables
            GameSpeed = speed;
            Steps = steps;
            Hare = new Hare(steps, HareColor);
            Turtle = new Turtle(steps, TortoiseColor);

            //Calculate the size of one box
            BoxSize = width / steps;
            Height = height;
        }
        public Race(int steps, int speed, int width, int height)
        {
            //Set the speed and hare variables
            GameSpeed = speed;
            Steps = steps;
            Hare = new Hare(steps);
            Turtle = new Turtle(steps);

            //Calculate the size of one box
            BoxSize = width / steps;

            Height = height;
        }
        public void Update()
        {
            Random rnd = new Random();
            int HareSteps = Hare.NextStepSize(rnd.Next(0, 100));
            int TurtleSteps = Turtle.NextStepSize(rnd.Next(0, 100));

            Hare.Move(HareSteps);
            Turtle.Move(TurtleSteps);

            //Set the bounds
            if(Hare.GetPosition() > this.Steps)
            {
                Hare.SetPosition(Steps);
            }
            else if(Turtle.GetPosition() > this.Steps)
            {
                Turtle.SetPosition(Steps);
            }
            else if(Hare.GetPosition() < 0)
            {
                Hare.SetPosition(0);
            }
            else if(Turtle.GetPosition() < 0)
            {
                Turtle.SetPosition(0);
            }

            //Fire winning events if necessary
            if(Hare.GetPosition()  == Steps && Turtle.GetPosition() == Steps)
            {
                GameOver?.Invoke("DRAW");
            }
            if(Hare.GetPosition() == Steps)
            {
                GameOver?.Invoke("HARE WIN");
            }
            if(Turtle.GetPosition() == Steps)
            {
                GameOver?.Invoke("TURTLE WIN");
            }
        }

        public void SetHareColor(Color hareColor)
        {
            Hare.SetColor(hareColor);
        }
        public void SetTurtleColor(Color turtleColor)
        {
            Turtle.SetColor(turtleColor);
        }
    }
}
