using AbstractFactory.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DbFactory db = new MongoFactory();

            var con = db.createConnection();
            var com = db.createCommand();

            con.Open();
            com.Execute();

            Console.ReadKey();
        }
    }
}
