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
            //test1();
            test2();
        }

        private static void test1()
        {
            RedisDB rdb = new RedisDB();
            string key = "t-1";
            string value = "test 1 value";

            rdb.SetValue(key, value);

            Console.WriteLine(string.Format("Value of {0}: {1}", key, value));
        }

        private static void test2()
        {
            Console.WriteLine("Write the host to connect to Redis: ");
            string host = Console.ReadLine();
            Console.WriteLine("Now write the port that Redis is listening to: ");
            string port = Console.ReadLine();

            RedisDB rdb = new RedisDB();
            rdb.test2(host, port);
        }
    }
}
