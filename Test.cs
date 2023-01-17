using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.Serialization
{
    internal class Test
    {
        public int Field1 { get; set; } = 1;
        public string Field2 { get; set; } = "Test";
        public decimal Field3 { get; set; } = 222.22m;
        public DateTime Field4 { get; set; } = DateTime.Now;
    }
}
