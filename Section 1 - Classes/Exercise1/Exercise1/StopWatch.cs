namespace Exercise1

{
    public class StopWatch()
    {
        public TimeSpan _duration {get; private set;}
        private DateTime _startTime;


        public void Start()
        {
            if (_startTime != default(DateTime))
                throw new ArgumentException("_startTime");
            _startTime = DateTime.Now;
        }

        public void Stop() 
        {
            if(_startTime == default(DateTime))
                throw new ArgumentNullException("_startTime");
            _duration = DateTime.Now - _startTime;
            _startTime = default(DateTime);
        }
    }
}
