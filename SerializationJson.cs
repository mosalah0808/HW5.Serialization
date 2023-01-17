using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace HW5.Serialization
{
    internal class SerializationJson
    {
        public static long SerializeJsonIterationTimes(object obj, int iterations, bool showInConsole = false)
            
        {
            string json;
            var timer = Stopwatch.StartNew();

            for (int i = 0; i <= iterations; i++)
            {
                json = JsonSerializer.Serialize(obj);

                if (showInConsole)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(json);
                }
            }

            timer.Stop();
            return timer.ElapsedMilliseconds;
        }

    }
}
