using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisAccess;

namespace hello_redis3
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
            try
            {
                Console.WriteLine("Write the host to connect to Redis: ");
                string host = Console.ReadLine();
                Console.WriteLine("Now write the port that Redis is listening to: ");
                string port = Console.ReadLine();

                RedisDB rdb = new RedisDB(host, port);

                Console.WriteLine("Doing ping to Redis...");
                Console.WriteLine(string.Format("Answer from Redis: {0}", rdb.Ping()));
                Console.WriteLine(string.Format("Saying hello from Redis: {0}", rdb.SayHello()));
                Console.WriteLine(string.Format("Redis, give me time: {0}", rdb.GiveTime().ToShortTimeString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("An error has ocurred: {0}", ex));
            }
            finally
            {
                Console.WriteLine("\nPress any key to finish...");
                Console.ReadKey();
            }
        }
    }
}
