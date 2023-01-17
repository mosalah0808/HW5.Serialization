using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.Serialization
{
    internal class DeserializationCSV
    {
        private static char FieldSeparator = ';';
        private static string LineSeparator = Environment.NewLine;

        public static object DeserializeFromCSVT(string csv)
            
        {
            Type objType = typeof(F);
            object obj = new F();

            var lines = csv.Split(LineSeparator);
            var fields = lines[0].Split(FieldSeparator);
            var values = lines[1].Split(FieldSeparator);

            for (int i = 0; i < fields.Length; i++)
            {
                var prop = objType.GetProperty(fields[i]);

                if (prop == null)
                    continue;

                prop.SetValue(obj, Convert.ChangeType(values[i], prop.PropertyType));
            }

            return obj;
        }

        public static long DeserializeFromCSVIterationTimes(string csv, int iterations)
        {
            var timer = Stopwatch.StartNew();

            for (int i = 0; i <= iterations; i++)
                DeserializeFromCSVT(csv);

            timer.Stop();
            return timer.ElapsedMilliseconds;
        }
    }
}
