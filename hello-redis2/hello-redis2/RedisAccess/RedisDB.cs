﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSRedis;

namespace RedisAccess
{
    public class RedisDB
    {


        public RedisDB()
        {

        }

        public void test2(string host, string port)
        {
            //RedisClient redis = new RedisClient(hostAndPort);

            using (var redis = new RedisClient(host, Convert.ToInt32(port)))
            {
                string ping = redis.Ping();
                string echo = redis.Echo("hello world from Redis");
                DateTime time = redis.Time();
            }
        }

        public void SetValue(string key, string value)
        {

        }

        public string GetValue(string key)
        {
            return "lala";
        }

    }
}
