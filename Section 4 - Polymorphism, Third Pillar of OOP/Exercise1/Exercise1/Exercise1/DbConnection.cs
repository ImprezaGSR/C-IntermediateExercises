namespace Exercise1
{
    public abstract class DbConnection
    {
        public string _connectionString { get; private set; }
        public TimeSpan _timeOut { get; private set; }
        protected DbConnection(string connectionString, TimeSpan timeOut)
        {
            if(connectionString != null && connectionString != "")
            {
                _connectionString = connectionString;
                _timeOut = timeOut;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public abstract void Open(TimeSpan openTime);

        public abstract void Close();
    }
}
