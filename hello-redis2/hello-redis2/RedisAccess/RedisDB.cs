using System;
using CSRedis;

namespace RedisAccess
{
    public class RedisDB
    {

        private RedisClient redisCli;

        public RedisDB()
        {
        }

        public RedisDB(string host, string port)
        {
            redisCli = new RedisClient(host, Convert.ToInt32(port));
        }

        public string Ping()
        {
            return redisCli.Ping();
        }

        public string SayHello()
        {
            return redisCli.Echo("hello world from Redis");
        }

        public DateTime GiveTime()
        {
            return redisCli.Time();
        }

        //public void test2(string host, string port)
        //{
        //    using (var redis = new RedisClient(host, Convert.ToInt32(port)))
        //    {
        //        string ping = redis.Ping();
        //        string echo = redis.Echo("hello world from Redis");
        //        DateTime time = redis.Time();
        //    }
        //}

        public void SetValue(string key, string value)
        {

        }

        public string GetValue(string key)
        {
            return "lala";
        }

    }
}
