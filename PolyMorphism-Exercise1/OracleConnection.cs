using System;

namespace PolyMorphism_Exercise1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectString) : base(ConnectString)
        {
            Timeout = new TimeSpan(0, 2, 0); //Arbitrary Value for Timeout
        }
        public override void Open()
        {
            Console.WriteLine("Oracle Connection Openned using string: {0}", ConnectionString);
            Console.WriteLine("Connection Will TimeOut in: {0} seconds", Timeout.TotalSeconds);
        }

        public override void Close()
        {
            Console.WriteLine("SQL Connection Closed");
        }
    }
}
