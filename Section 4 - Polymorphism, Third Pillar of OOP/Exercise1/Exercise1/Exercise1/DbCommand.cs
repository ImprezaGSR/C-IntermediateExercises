namespace Exercise1
{
    class DbCommand
    {
        public string _instruction {  get; private set; }
        public DbConnection _connection { get; private set; }
        public DbCommand(string instruction, DbConnection connection)
        {
            if (instruction != null && instruction != "" && connection != null) {
                _connection = connection;
                _instruction = instruction;
            }
            else 
            {
                throw new ArgumentNullException();
            }
        }

        public void Execute(TimeSpan openTime)
        {
            _connection.Open(openTime);
            Console.WriteLine("Running Instruction " + _instruction + " in " + _connection._connectionString + "...");
            _connection.Close();
        }
    }
}
