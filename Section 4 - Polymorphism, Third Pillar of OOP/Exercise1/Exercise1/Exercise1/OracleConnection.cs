namespace Exercise1
{
    partial class Program
    {
        class OracleConnection : DbConnection
        {
            public OracleConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
            {
            }

            public override void Open(TimeSpan openTime)
            {
                if (openTime <= _timeOut)
                {
                    Console.WriteLine("Opening " + _connectionString + " in Oracle Server...");
                }
                else
                {
                    throw new TimeoutException();
                }
            }

            public override void Close()
            {
                Console.WriteLine("Closing " + _connectionString + " in Oracle Server...");
            }
        }
    }
}
