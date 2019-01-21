using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TandHRace
{
    class Contender
    {
        protected int Position;
        protected int NumberOfSteps;
        protected Color BodyColor;
        protected List<int> Moves;

        public Contender(int position, int steps, Color color)
        {
            Position = position;
            NumberOfSteps = steps;
            BodyColor = color;
            //Store the last five moves
            Moves = new List<int>();
        }
        public Contender(int steps, Color color)
        {
            NumberOfSteps = steps;
            BodyColor = color;
            //Store the last five moves
            Moves = new List<int>();
        }
        public Contender()
        {
            //Store the last five moves
            Moves = new List<int>();
        }
        public int GetPosition()
        {
            return Position;
        }
        public void SetPosition(int pos)
        {
            Position = pos;
        }
        public void SetColor(Color color)
        {
            BodyColor = color;
        }
        public Color GetColor()
        {
            return BodyColor;
        }

    }
    class Hare : Contender
    {
        public Hare(int steps, Color color) : base(steps, color)
        {

        }
        public Hare(int steps) : base(steps, Color.Brown)
        {

        }
        public Hare()
        {

        }
        public int NextStepSize(int r)
        {
            if ((r >= 0) && (r <= 20))
            {
                return 0;
            }
            else if ((r > 20) && (r <= 40))
            {
                return 9;
            }
            else if ((r > 40) && (r <= 50))
            {
                return -12;
            }
            else if ((r > 50) && (r <= 80))
            {
                return 1;
            }
            else
            {
                return -2;
            }
        }
        public void Move(int steps)
        {
            //Move the hare
            base.SetPosition(base.GetPosition() + steps);
            Moves.Add(steps);
        }
        public void Draw(Graphics g, Race r)
        {
            //Draw the hare
            int Pos = base.GetPosition();
            int BoxWidth = r.BoxSize;
            Color HareCol = base.GetColor();

            Rectangle rctBody = new Rectangle(new Point(Pos * BoxWidth, r.Height/2), new Size(BoxWidth, BoxWidth));
            Brush HareBrush = new SolidBrush(HareCol);
            Pen HarePen = new Pen(HareBrush, 2);

            g.DrawEllipse(HarePen, rctBody);
        }
    }
    class Turtle : Contender
    {
        public Turtle(int steps, Color color): base(steps, color)
        {

        }
        public Turtle(int steps):base(steps, Color.LightGreen)
        {

        }
        public Turtle()
        {

        }
        public int NextStepSize(int r)
        {
            if ((r >= 0) && (r <= 50))
            {
                return 3;
            }
            else if ((r > 50) && (r <= 70))
            {
                return -6;
            }
            else
            {
                return 1;
            }
        }
        public void Move(int steps)
        {
            //Move the turtle
            base.SetPosition(base.GetPosition() + steps);
            Moves.Add(steps);
        }
        public void Draw(Graphics g, Race r)
        {
            //Draw the turtle
            int Pos = base.GetPosition();
            int BoxWidth = r.BoxSize;
            Color TurtleCol = base.GetColor();

            Rectangle rctBody = new Rectangle(new Point(Pos * BoxWidth, r.Height/2), new Size(BoxWidth, BoxWidth));
            Brush TurtleBrush = new SolidBrush(TurtleCol);
            Pen TurtlePen = new Pen(TurtleBrush, 2);

            g.DrawRectangle(TurtlePen, rctBody);
        }
        public void DrawPic(Graphics g, Race r)
        {
            Image turtle = Image.FromFile("Turtle.png");
            for(int move = Moves.Count()-1; move >= 0; move++)
            {
                int cStep = Moves[move];
                if(cStep> 0)
                {
                    //Most recent non-stationary move was a right move, leave the image
                    break;
                }
                else if(cStep< 0)
                {
                    //Most recent non-stationary move was a left move, flip the image
                    turtle.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                }
                else
                {
                    continue;
                }
            }
            Point position = new Point(base.GetPosition()*r.BoxSize, r.Height - turtle.Height-30);
            g.DrawImage(turtle, position);
        }
    }
}
