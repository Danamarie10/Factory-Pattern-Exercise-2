using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDatabase(string dataBase)
        {
            switch(dataBase.ToLower())
            {
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                case "listdata":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess();
            }
        }
    }
}
