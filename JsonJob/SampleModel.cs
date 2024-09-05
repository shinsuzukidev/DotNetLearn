using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonJob
{
    public class SampleModel
    {
        public string Name { get; set; } = "";

        public int Age { get; set; } = 0;

        public List<string> ItemList { get; set; } = new();
    }
}
