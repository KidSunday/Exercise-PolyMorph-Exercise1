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
            //Exercises for Section 5, Lecture 31 of C# Intermediate Classes
            //https://www.udemy.com/csharp-intermediate-classes-interfaces-and-oop/learn/v4/t/lecture/2480692?start=0
            //Polymorphism Exercise 1

            Console.WriteLine("Display Examples of class implementation from Abstract Class and Method");

            //var sqlError = new SqlConnection(null); //Test Exception Error
            var sqlConnect = new SqlConnection("db01,u=admin,p=hunter2");
            sqlConnect.Open();
            sqlConnect.Close();

            var oracleConnect = new OracleConnection("db03--u=root--p=root");
            oracleConnect.Open();
            oracleConnect.Close();
        }
    }
}
