using System;
using Newtonsoft.Json;

namespace JsonJob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__start");

            //----------------------------------------- Dictionary ⇔ json
            // model to json
            var dic = new Dictionary<string, string> {
               { "item1", "aaa"},
               { "item2", "bbb"},
               { "item3", "ccc"} 
            };
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(dic);

            // json to model
            var dicModel = Newtonsoft.Json.JsonConvert.DeserializeObject(json);


            //----------------------------------------- Model ⇔ json
            var s = new SampleModel {
                Name = "kato",
                Age = 30,
                ItemList = new List<string> { "item1", "item2" }
            };

            // model to json
            var jsonSampleModel = Newtonsoft.Json.JsonConvert.SerializeObject(s);  

            // json to model
            var objSampleModel = Newtonsoft.Json.JsonConvert.DeserializeObject<SampleModel>(jsonSampleModel);

            Console.WriteLine("__end");
        }
    }
}
