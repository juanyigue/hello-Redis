using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisAccess;

namespace hello_redis2
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisDB rdb = new RedisDB();
            string key = "t-1";
            string value = "test 1 value";

            rdb.SetValue(key, value);

            Console.WriteLine(string.Format("Value of {0}: {1}", key, value));
        }
    }
}
