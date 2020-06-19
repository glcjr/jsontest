using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jsontest
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public static string Serialize(Person value)
        {
            //  return JsonSerializer.Serialize<Person>(value);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize<Person>(value, options);
        }
        public static Person Deserialize(string value)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true
            };
            return JsonSerializer.Deserialize<Person>(value, options);
        }
    }
}
