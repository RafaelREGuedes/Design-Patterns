using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mongo
{
    public class MongoCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Comando executado no mongoDb.");
        }
    }
}
