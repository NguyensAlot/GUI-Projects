using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MediaPlayer
{
    public enum MusicNav
    {
        Previous = 0,
        Next
    };

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // some flags
        private bool isDraggingSlider = false;
        private bool isPlaying = false;
        // list that will be populated by paths to videos
        List<string> playList;
        // index for accessing the list
        int curr = 0;
        // current video time and max video time
        double time = 0;
        double maxTime = 0;

        public MainWindow()
        {
            InitializeComponent();
            // initialize playList
            CreateList();

            // initialize timer
            DispatcherTimer timer = new DispatcherTimer();
            // set the tick interval
            timer.Interval = TimeSpan.FromMilliseconds(1);
            // add the event
            timer.Tick += timer_Tick;
            // start the timer
            timer.Start();
        }

        /// <summary>
        /// Update video timer every tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            // make sure media element has a source, timespan, and user isn't adjusting slider
            if ((mePlayer.Source != null) && (mePlayer.NaturalDuration.HasTimeSpan) && (!isDraggingSlider))
            {
                // set min-bound
                sliProgress.Minimum = 0;
                // set max-bound
                sliProgress.Maximum = mePlayer.NaturalDuration.TimeSpan.TotalSeconds;
                maxTime = mePlayer.NaturalDuration.TimeSpan.TotalSeconds;
                // set value to current time in video
                sliProgress.Value = mePlayer.Position.TotalSeconds;
                time = sliProgress.Value;
            }

            // when video finishes, adjust play/pause button content
            if (time == maxTime && maxTime != 0)
            {
                isPlaying = false;
                mbMenu.btnPlayPause.Content = "Play";
                mePlayer.Stop();
            }
        }

        /// <summary>
        /// Set flag to execute play/pause button command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayPause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (mePlayer != null) && (mePlayer.Source != null); ;
        }

        /// <summary>
        /// Starts and pauses the media element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayPause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PlayPause();
        }

        /// <summary>
        /// Set flag to execute previous button command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousTrack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        /// <summary>
        /// Adjusts the index and starts the previous video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousTrack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AdjustIndex(MusicNav.Previous);
            PlayPause();
        }

        /// <summary>
        /// Set flag to execute next button command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextTrack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        /// <summary>
        /// Adjusts the index and starts the next video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextTrack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AdjustIndex(MusicNav.Next);
            PlayPause();
        }

        /// <summary>
        /// Sets flag to execute stop button command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isPlaying;
        }

        /// <summary>
        /// Stops the media element if media element is playing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mePlayer.Stop();
            isPlaying = false;
            mbMenu.btnPlayPause.Content = "Play";
        }

        /// <summary>
        /// Sets boolean value for user dragging slider bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sliProgress_DragStarted(object sender, DragStartedEventArgs e)
        {
            isDraggingSlider = true;
        }
        
        /// <summary>
        /// Sets position in video when user is done sliding bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sliProgress_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            isDraggingSlider = false;
            mePlayer.Position = TimeSpan.FromSeconds(sliProgress.Value);
        }

        /// <summary>
        /// Updates timer when slider value has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sliProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(sliProgress.Value).ToString(@"hh\:mm\:ss\.ff");
        }

        /// <summary>
        /// Allows for adjusting volume using the mouse wheel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            // set max bound
            mePlayer.Volume = (mePlayer.Volume < 0) ? 0 : mePlayer.Volume;
            // set max bound
            mePlayer.Volume = (mePlayer.Volume > 1) ? 1 : mePlayer.Volume;
            // adjust volume
            mePlayer.Volume += (e.Delta > 0) ? 0.1 : -0.1;
        }


        // Private non-event handling methods ========================================

        /// <summary>
        /// Starts and pauses the media element. Also adjusts button content and boolean value.
        /// </summary>
        public void PlayPause()
        {
            if (mePlayer.Source == null) mePlayer.Source = new Uri(playList[curr], UriKind.Relative);
            // play
            if (!isPlaying && mePlayer.Source != null)
            {
                mePlayer.Play();
                isPlaying = true;
                mbMenu.btnPlayPause.Content = "Pause";
            }
            // pause
            else
            {
                mePlayer.Pause();
                isPlaying = false;
                mbMenu.btnPlayPause.Content = "Play";
            }
        }

        /// <summary>
        /// Initialize a list of strings and populates it
        /// </summary>
        private void CreateList()
        {
            playList = new List<string>();
            playList.Add("../../Resources/animalVideo.mp4");
            playList.Add("../../Resources/animalVideo2.mp4");
            playList.Add("../../Resources/knifeTrick.wmv");
            playList.Add("../../Resources/squatting.mp4");
        }

        /// <summary>
        /// Used for when clicking the next or previous button. 
        /// Adjust index and adjust media element source.
        /// </summary>
        /// <param name="mn"></param>
        private void AdjustIndex(MusicNav mn)
        {
            if (mn == MusicNav.Previous)
                curr -= (curr > 0) ? 1 : -(playList.Count - 1);
            else
                curr += (curr < playList.Count - 1) ? 1 : -(playList.Count - 1);

            isPlaying = false;
            mePlayer.Source = new Uri(playList[curr], UriKind.Relative);
        }
    }
}