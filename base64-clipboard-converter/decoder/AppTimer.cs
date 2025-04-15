namespace decoder
{
    public class AppTimer
    {
        private System.Windows.Forms.Timer timer;
        private int timeElapsed;

        public event EventHandler TimerStopped;
        public event EventHandler TimeUpdated;

        public int TimeElapsed
        {
            get { return timeElapsed; }
        }

        public AppTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += OnTimerTick;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
            timeElapsed = 0;
            OnTimerStopped();
        }

        public void Reset()
        {
            timeElapsed = 0;
            OnTimeUpdated();
        }

        public bool GetStatus()
        {
            return timer.Enabled;
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            timeElapsed++;
            if (timeElapsed >= 15 * 60)
            {
                Stop();
            }
            OnTimeUpdated();
        }

        private void OnTimeUpdated()
        {
            TimeUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void OnTimerStopped()
        {
            TimerStopped?.Invoke(this, EventArgs.Empty);
        }
    }
}
