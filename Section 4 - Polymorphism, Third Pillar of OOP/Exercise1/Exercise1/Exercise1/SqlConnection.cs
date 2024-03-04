namespace Exercise1
{
    class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {
        }

        public override void Open(TimeSpan openTime)
        {
            if(openTime <= _timeOut)
            {
                Console.WriteLine("Opening " + _connectionString + " in SQL Connection...");
            }
            else
            {
                throw new TimeoutException();
            }
        }

        public override void Close() 
        {
            Console.WriteLine("Closing " + _connectionString + " in SQL Connection...");
        }
    }
}
