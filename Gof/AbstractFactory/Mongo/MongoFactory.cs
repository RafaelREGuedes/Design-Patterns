using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mongo
{
    public class MongoFactory : DbFactory
    {
        public override DbCommand createCommand()
        {
            return new MongoCommand();
        }

        public override DbConnection createConnection()
        {
            return new MongoConnection();
        }
    }
}
