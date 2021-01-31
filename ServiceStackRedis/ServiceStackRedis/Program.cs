using ServiceStack.Redis;
using System;

namespace ServiceStackRedis
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                Age = 34,
                Name = "ali"
            };
            //local not config
            //6000 in second Service Stack Redis
            using (var client = new RedisClient("localhost", 6379)) 
            {
                var sevenItems = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };

                client.Publish("A", sevenItems);


             
                //for (int i = 0; i < 1000; i++)
                //{
                //    client.Set(i.ToString(), "val" + i);
                //}
              // client.Set<Person>("ok", p);
            }

     
            Console.WriteLine($"Hello World!");
        }
    }
}
