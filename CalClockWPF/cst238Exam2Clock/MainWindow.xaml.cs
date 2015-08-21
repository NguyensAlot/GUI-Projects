using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Globalization;
using System.Media;

namespace cst238Exam2Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        DispatcherTimer timer;
        Point center;
        Point pt1, pt2;
        Line[] tickMarks;
        int secLength;
        int minLength;
        int hourLength;
        Ellipse clockFace;
        Line secondHand;
        Line minuteHand;
        Line hourHand;
        SoundPlayer sp;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            Title = DateTime.Now.ToString("D");

            #region Initialization
            // initialize timer
            timer = new DispatcherTimer();

            // initialize points
            center = new Point(canvasClock.Width / 2, canvasClock.Height / 2);

            // initialize array of tick marks
            tickMarks = new Line[24];
            for (int i = 0; i < 24; i++)
            {
                tickMarks[i] = new Line() { Stroke = Brushes.Black, StrokeThickness = 1 };
                canvasClock.Children.Add(tickMarks[i]);
            }

            // initialize sound player
            sp = new SoundPlayer(@"E:\Anthony Nguyen\Documents2\COLLEGE\CST238_GUI\EXAMS\cst238Exam2Clock\cst238Exam2Clock\clockTickWave.wav");
            sp.Play();

            // initialize lengths
            secLength = 60;
            minLength = 40;
            hourLength = 20;

            // set label contents to current time
            lblTimeBox.Content = DateTime.Now.ToLongTimeString();

            // initialize timer
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            // initialize clock face
            clockFace = new Ellipse();
            clockFace.Stroke = Brushes.Black;
            clockFace.Fill = Brushes.Transparent;
            clockFace.Width = canvasClock.Width;
            clockFace.Height = canvasClock.Height;

            // initialize clock hands
            //second
            secondHand = new Line();
            secondHand.Stroke = Brushes.Red;
            secondHand.StrokeThickness = 1;
            //minute
            minuteHand = new Line();
            minuteHand.Stroke = Brushes.Black;
            minuteHand.StrokeThickness = 1;
            //hour
            hourHand = new Line();
            hourHand.Stroke = Brushes.Black;
            hourHand.StrokeThickness = 1;
            // draw clock hands
            DrawClockHands();

            // draw tick marks
            DrawTicks12();

            // add children to canvas
            canvasClock.Children.Add(clockFace);
            canvasClock.Children.Add(secondHand);
            canvasClock.Children.Add(minuteHand);
            canvasClock.Children.Add(hourHand);
            #endregion
        }

        /// <summary>
        /// Handles actions done every timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            sp.Play();
            // draw clock hands
            DrawClockHands();
            

            // 12-hour time format
            if (!(bool)cbMilitaryTime.IsChecked)
            {
                // update time format
                lblTimeBox.Content = DateTime.Now.ToLongTimeString();
                // update clock ticks
                DrawTicks12();
            }

            // 24-hour time format
            else
            {
                lblTimeBox.Content = DateTime.Now.ToString("HH:mm:ss");
                DrawTicks24();
            }
        }

        /// <summary>
        /// Update clock hands according to the current time
        /// </summary>
        private void DrawClockHands()
        {
            // set second hand position
            secondHand.X1 = center.X;
            secondHand.Y1 = center.Y;
            secondHand.X2 = (int)(secLength * Math.Sin(Math.PI / 30 * (float)DateTime.Now.Second % 60)) + center.X;
            secondHand.Y2 = (int)(-secLength * Math.Cos(Math.PI / 30 * (float)DateTime.Now.Second % 60)) + center.Y;

            // set minute hand position
            minuteHand.X1 = center.X;
            minuteHand.Y1 = center.Y;
            minuteHand.X2 = (int)(minLength * Math.Sin(Math.PI / 30 * DateTime.Now.Minute % 60)) + center.X;
            minuteHand.Y2 = (int)(-minLength * Math.Cos(Math.PI / 30 * DateTime.Now.Minute % 60)) + center.Y;

            // set hour hand position according to time format
            hourHand.X1 = center.X;
            hourHand.Y1 = center.Y;
            // 12-hour format
            if (!(bool)cbMilitaryTime.IsChecked)
            {
                hourHand.X2 = (int)(hourLength * Math.Sin(Math.PI / 6 * (DateTime.Now.Hour % 12))) + center.X;
                hourHand.Y2 = (int)(-hourLength * Math.Cos(Math.PI / 6 * (DateTime.Now.Hour % 12))) + center.Y;
            }
            // 24-hour format
            else
            {
                hourHand.X2 = (int)(hourLength * Math.Sin(Math.PI / 12 * DateTime.Now.Hour % 12)) + center.X;
                hourHand.Y2 = (int)(-hourLength * Math.Cos(Math.PI / 12 * DateTime.Now.Hour % 12)) + center.Y;
            }
        }

        /// <summary>
        /// Draw tick marks for 12-hour format clock face
        /// </summary>
        private void DrawTicks12()
        {
            // basically erase all tick marks
            for (int i = 0; i < 24; i++)
            {
                tickMarks[i].StrokeThickness = 0;
            }

            // draw the necessary tick marks
            for (int i = 1; i <= 24; i++)
            {
                // mark ticks if no number is present
                if (i % 3 != 0)
                {
                    // set points
                    pt1 = new Point((int)((secLength - 6) * Math.Sin(Math.PI / 6 * i) + center.X - 3), (int)(-(secLength - 9) * Math.Cos(Math.PI / 6 * i)) + center.Y - 3);
                    pt2 = new Point((int)((secLength - 3) * Math.Sin(Math.PI / 6 * i) + center.X - 3), (int)(-(secLength - 6) * Math.Cos(Math.PI / 6 * i)) + center.Y - 3);
                    // reset thickness
                    tickMarks[i - 1].StrokeThickness = 1;
                    // set position
                    tickMarks[i - 1].X1 = pt1.X + 3;
                    tickMarks[i - 1].Y1 = pt1.Y + 3;
                    tickMarks[i - 1].X2 = pt2.X + 3;
                    tickMarks[i - 1].Y2 = pt2.Y + 3;
                }
            }
        }

        /// <summary>
        /// Draw tick marks for 24-hour format clock face
        /// </summary>
        private void DrawTicks24()
        {
            // handle all tick marks
            for (int i = 1; i <= 24; i++)
            {
                // only draw where numbers aren't present
                if (i % 6 != 0)
                {
                    // set points
                    pt1 = new Point((int)((secLength - 6) * Math.Sin(Math.PI / 12 * i) + center.X - 3), (int)(-(secLength - 9) * Math.Cos(Math.PI / 12 * i)) + center.Y - 3);
                    pt2 = new Point((int)((secLength - 3) * Math.Sin(Math.PI / 12 * i) + center.X - 3), (int)(-(secLength - 6) * Math.Cos(Math.PI / 12 * i)) + center.Y - 3);

                    // reset thickness
                    tickMarks[i - 1].StrokeThickness = 1;
                    // set position
                    tickMarks[i - 1].X1 = pt1.X + 3;
                    tickMarks[i - 1].Y1 = pt1.Y + 3;
                    tickMarks[i - 1].X2 = pt2.X + 3;
                    tickMarks[i - 1].Y2 = pt2.Y + 3;
                }
            }
        }

        /// <summary>
        /// Handler for military time check box, if unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbMilitaryTime_Unchecked(object sender, RoutedEventArgs e)
        {
            // update time format
            lblTimeBox.Content = DateTime.Now.ToLongTimeString();

            // update clock ticks
            DrawTicks12();

            // update clock numbers
            lblLeftHour.Content = "9";
            lblTopHour.Content = "12";
            lblRightHour.Content = "3";
            lblBottomHour.Content = "6";

            // update hour hand
            hourHand.X2 = (int)(hourLength * Math.Sin(Math.PI / 6 * (DateTime.Now.Hour % 12))) + center.X;
            hourHand.Y2 = (int)(-hourLength * Math.Cos(Math.PI / 6 * (DateTime.Now.Hour % 12))) + center.Y;
        }

        /// <summary>
        /// Handler for military time check box, if checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbMilitaryTime_Checked(object sender, RoutedEventArgs e)
        {
            // update time format
            lblTimeBox.Content = DateTime.Now.ToString("HH:mm:ss");

            // update clock ticks
            DrawTicks24();

            // update clock numbers
            lblLeftHour.Content = "18";
            lblTopHour.Content = "24";
            lblRightHour.Content = "6";
            lblBottomHour.Content = "12";

            // update hour hand
            hourHand.X2 = (int)(hourLength * Math.Sin(Math.PI / 12 * DateTime.Now.Hour % 12)) + center.X;
            hourHand.Y2 = (int)(-hourLength * Math.Cos(Math.PI / 12 * DateTime.Now.Hour % 12)) + center.Y;
        }
    }
}
