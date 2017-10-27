using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism_Exercise1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display Examples of class implementation from Abstract Class and Method");

            var sqlConnect = new SqlConnection("db01,u=admin,p=hunter2");
            sqlConnect.Open();
            sqlConnect.Close();

            var oracleConnect = new OracleConnection("db03--u=root--p=root");
            oracleConnect.Open();
            oracleConnect.Close();
        }
    }
}
