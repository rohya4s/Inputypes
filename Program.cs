using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Inputypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string data = File.ReadAllText(@"C:\Users\VSOFT\Desktop\C#progm\Inputypes\data.json");
            List<DataModel> dataModels = JsonConvert.DeserializeObject<List<DataModel>>(data);
            //Console.WriteLine(dataModels.ToString());
            //foreach (DataModel item in dataModels)
            //{
            //    Console.WriteLine(item);
            //}
            //// string name = dataModels[1].name;
            // // Taking input from user
            string input = MyInput.input();
             Console.WriteLine(dataModels[0].value + input);
            // int number = MyInput.Intinput();
            // Console.WriteLine("You entered number: " + number);

            // // --Basic Arithmetic Operations
            // Operations.Add(10, 20);
            // Operations.Sub(20, 10);
            // Operations.Mul(10, 20);
            // Operations.Div(20, 10);

            Person person = new Person();

           // // Convert to JSON
           // string json = JsonConvert.SerializeObject(person);
           // Console.WriteLine(json);
           // //getting value from JSON string
           // JObject jObject = JObject.Parse(json);
           // Console.WriteLine(jObject["name"]);

            //Convert back to object
            //string jsonvalue = "{\"age\":\"25\",\"name\":\"rahul\"}";
            //person = JsonConvert.DeserializeObject<Person>(jsonvalue);
            //Console.WriteLine(person.age + " " + person.name);

            //TypeConversion.TypeConvertlongfromInt(214748);
            //TypeConversion.TypeConvertIntfromlong(21474L);
        }
    }
}
