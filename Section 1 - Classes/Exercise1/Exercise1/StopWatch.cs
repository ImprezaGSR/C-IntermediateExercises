namespace Exercise1

{
    public class StopWatch()
    {
        public TimeSpan _duration {get; private set;}
        private DateTime _startTime;


        public void Start(DateTime time)
        {
            if (_startTime != default(DateTime))
                throw new ArgumentException("_startTime");
            _startTime = time;
        }

        public void Stop(DateTime time) 
        {
            if(_startTime == default(DateTime))
                throw new ArgumentNullException("_startTime");
            else if(time < _startTime)
                throw new ArgumentOutOfRangeException("time");
            _duration = time - _startTime;
            _startTime = default(DateTime);
        }
    }
}
