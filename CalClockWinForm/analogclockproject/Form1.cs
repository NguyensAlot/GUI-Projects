using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClockProject
{

    public partial class AnalogClockForm : Form
    {
        DateTime clock;//DateTime is a struct contaning the time
        Point center;//from System.Drawing
        Graphics g;//from System.Drawing
        Pen blackPen;//for hour hand
        Pen redPen;//second hand
        Pen bluePen;//minute hand
        Point hp, mp, sp;//the 'endpoint' of each hand; we need to update these every second

        public AnalogClockForm()
        {
            InitializeComponent();
            center = new Point(this.Width / 2 + 100, this.Height / 2 - 40);
            g = this.CreateGraphics();
            redPen = new Pen(Color.Red, 1);
            bluePen = new Pen(Color.Blue, 2);
            blackPen = new Pen(Color.Black, 3);
        }

        //The cTimer component raises a 'tick' event every second
        //This is the event handler "What to do every second?"
        private void cTimer_Tick(object sender, EventArgs e)
        {
            Font f = new Font("Times New Roman", 16);
            Point p = new Point();
            Point p2 = new Point();
            float sHand = 100;
            float mHand = 75;
            float hHand = 50;

            // First off, refresh the screen for every timer tick; this wipes away the old stuff
            this.Refresh();
            // Get the current time and store it in clock
            clock = DateTime.Now;

            // initial position of ellipse is (center - length of hand)
            // size = max size of hand length * 2 + some
            g.DrawEllipse(blackPen, center.X - sHand, center.Y - sHand, sHand * 2 + 2, sHand * 2 + 2);

            //Compute the 'endpoint' of the second hand wrt center based on the # seconds past 
            //Take a look at the following two lines - draw a picture if you need to to see how they work
            sp.Y = (int)(-sHand * Math.Cos(Math.PI / 30 * clock.Second % 60)) + center.Y;
            sp.X = (int)(sHand * Math.Sin(Math.PI / 30 * clock.Second % 60)) + center.X;
            //Draw the second hand now, from the center to its endpoint
            g.DrawLine(redPen, center, sp);

            //Now, let's do something similar for the minute hand
            //Why do the constants here have the values that they have?
            mp.Y = (int)(-mHand * Math.Cos(Math.PI / 30 * clock.Minute % 60)) + center.Y;
            mp.X = (int)(mHand * Math.Sin(Math.PI / 30 * clock.Minute % 60)) + center.X;
            g.DrawLine(blackPen, center, mp);

            // 12-hour format
            if (!cbMilitaryTime.Checked)
            {
                //And now, the hour hand
                //Why do the constants here have the values that they have?
                hp.Y = (int)(-hHand * Math.Cos(Math.PI / 6 * clock.Hour % 12)) + center.Y;
                hp.X = (int)(hHand * Math.Sin(Math.PI / 6 * clock.Hour % 12)) + center.X;

                // disply 12-hour time format
                timeBox.Text = String.Format("{0:T}", clock);
                lblTimeBox.Text = String.Format("{0:T}", clock);

                // handles ticks and numbers on clock face
                for (int i = 1; i <= 12; i++)
                {
                    // display 4 numbers
                    if (i % 3 == 0)
                        // 140 is distance from center
                        // PI / 6 gives 12 slices in a circle because 2PI in a circle
                        g.DrawString(i.ToString(), f, blackPen.Brush,
                            new Point((int)((sHand - 10) * Math.Sin(Math.PI / 6 * i) + center.X - 10), (int)(-(sHand - 10) * Math.Cos(Math.PI / 6 * i)) + center.Y - 10));

                    // define some points for drawing ticks
                    p = new Point((int)((sHand - 10) * Math.Sin(Math.PI / 6 * i) + center.X - 5), (int)(-(sHand - 15) * Math.Cos(Math.PI / 6 * i)) + center.Y - 5);
                    p2 = new Point((int)((sHand - 5) * Math.Sin(Math.PI / 6 * i) + center.X - 5), (int)(-(sHand - 10) * Math.Cos(Math.PI / 6 * i)) + center.Y - 5);
                    // draw ticks where there are no numbers
                    if (i % 3 != 0)
                        g.DrawLine(blackPen, p.X + 5, p.Y + 5, p2.X + 5, p2.Y + 5);
                }
            }
            // 24-hour format
            else
            {
                // 24-hour hour hand format
                hp.Y = (int)(-hHand * Math.Cos(Math.PI / 12 * clock.Hour % 12)) + center.Y;
                hp.X = (int)(hHand * Math.Sin(Math.PI / 12 * clock.Hour % 12)) + center.X;

                // 24-hour time format
                timeBox.Text = clock.ToString("HH:mm:ss");
                lblTimeBox.Text = clock.ToString("HH:mm:ss");

                // handles ticks and numbers on clock face
                for (int i = 1; i <= 24; i++)
                {
                    // display 4 numbers
                    if (i % 6 == 0)
                        g.DrawString(i.ToString(), f, blackPen.Brush,
                            new Point((int)((sHand - 10) * Math.Sin(Math.PI / 12 * i) + center.X - 10), (int)(-(sHand - 10) * Math.Cos(Math.PI / 12 * i)) + center.Y - 10));

                    // set some points for ticks
                    p = new Point((int)((sHand - 10) * Math.Sin(Math.PI / 12 * i) + center.X - 5), (int)(-(sHand - 15) * Math.Cos(Math.PI / 12 * i)) + center.Y - 5);
                    p2 = new Point((int)((sHand - 5) * Math.Sin(Math.PI / 12 * i) + center.X - 5), (int)(-(sHand - 10) * Math.Cos(Math.PI / 12 * i)) + center.Y - 5);

                    // fill the rest of the hour spots with ticks
                    if (i % 6 != 0)
                        g.DrawLine(blackPen, p.X + 5, p.Y + 5, p2.X + 5, p2.Y + 5);
                }
            }
            // draw the hour hand
            g.DrawLine(blackPen, center, hp);
        }
    }
}
