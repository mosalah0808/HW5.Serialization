using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW5.Serialization
{
    internal class SerializationCSV
    {
        private static char FieldSeparator = ';';
        private static string LineSeparator = Environment.NewLine;

    

        public static string SerializeFromObjectToCSV(object obj)
        {
            Type objType = obj.GetType();
            var lstProperties = objType.GetProperties();

            var lstSerialize = new Dictionary<string, string>();

            for (int i = 0; i < lstProperties.Length; i++)
                lstSerialize.Add(lstProperties[i].Name, lstProperties[i].GetValue(obj).ToString());

            var csvString = new StringBuilder();
            csvString.AppendJoin(FieldSeparator, lstSerialize.Keys).Append(LineSeparator);
            csvString.AppendJoin(FieldSeparator, lstSerialize.Values);

            return csvString.ToString();
        }

        public static long SerializeCSVIterationTimes(object obj, int iterations, bool showInConsole = false)
            
        {
            var timer = Stopwatch.StartNew();
            string csv;

            for (int i = 0; i <= iterations; i++)
            {
                csv = SerializeFromObjectToCSV(obj);

                if (showInConsole)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(csv);
                }
            }

            timer.Stop();
            return timer.ElapsedMilliseconds;
        }

    }
}
