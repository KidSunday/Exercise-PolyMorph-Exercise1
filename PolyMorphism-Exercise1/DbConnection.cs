using System;

namespace PolyMorphism_Exercise1
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectString)
        {
            if (connectString == null || connectString == "")
            {
                throw new ArgumentException("Connection String NULL or Empty");
            }
            this.ConnectionString = connectString;
            Timeout = new TimeSpan(0, 1, 1);
        }

        public abstract void Open();
        public abstract void Close();

    }
}
