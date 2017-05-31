using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Redis.Common.Test
{
    [TestClass]
    public class UnitTest1
    {
        static Redis.RedisHelper redisHelper = new Redis.RedisHelper(0);
        [TestMethod]
        public void Add()
        {
          
            bool isSet = redisHelper.StringSet("key-1", "100", new TimeSpan(0, 5, 0));
            Assert.IsTrue(isSet);
        }

        [TestMethod]
        public void Get()
        {
            string str = redisHelper.StringGet("key-1");
            Assert.IsNotNull(str);
        }
    }
}
