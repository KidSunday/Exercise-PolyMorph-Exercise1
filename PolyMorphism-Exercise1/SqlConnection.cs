using System;

namespace PolyMorphism_Exercise1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string ConnectString) : base(ConnectString)
        {
            Timeout = new TimeSpan(0, 1, 0); //Arbitrary Value for Timeout
        }
        public override void Open()
        {
            Console.WriteLine("SQL Connection Open using string: {0}", ConnectionString);
            Console.WriteLine("Connection Will TimeOut in: {0} seconds", Timeout.TotalSeconds);
            
        }

        public override void Close()
        {
            Console.WriteLine("SQL Connection Closed");
        }
    }
}
