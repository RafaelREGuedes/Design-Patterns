using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mongo
{
    public class MongoConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Conexão aberta no mongoDb.");
        }
    }
}
