using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Exercise1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sql = new SqlConnection("Data1", new TimeSpan(0, 0, 1, 0, 0));
                var oracle = new OracleConnection("Data2", new TimeSpan(0, 0, 0, 30, 0));

                //Console.WriteLine(sql._timeOut);
                //Console.WriteLine(oracle._timeOut);


                var command = new DbCommand("Instruction1", sql);
                //var command = new DbCommand("Instruction2", oracle);

                command.Execute(new TimeSpan(0, 0, 0, 15, 0));
            }
            catch (Exception){
                Console.WriteLine("ガッ");
            }
        }
    }
}
