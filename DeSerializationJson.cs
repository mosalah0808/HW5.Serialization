using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HW5.Serialization
{
    internal class DeSerializationJson
    {
        public static long DeserializeJson<T>(string json, int iterations)
        {
            var timer = Stopwatch.StartNew();

            for (int i = 0; i <= iterations; i++)
                JsonSerializer.Deserialize(json, typeof(T));

            timer.Stop();
            return timer.ElapsedMilliseconds;
        }
    }
}
