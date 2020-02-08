using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Config
{
    public class JsonFile
    {
        private readonly string fileContent;
        private readonly string resourceName;
        private JObject JsonObject => JsonConvert.DeserializeObject<JObject>(fileContent);

        public JsonFile(string filename)
        {
            resourceName = filename;
            fileContent = File.ReadAllText(filename);
        }

        public T GetValue<T>(string jsonPath)
        {
            var node = GetJsonNode(jsonPath);
            return node.ToObject<T>();
        }

        private JToken GetJsonNode(string jsonPath)
        {
            var node = JsonObject.SelectToken(jsonPath);
            if (node == null)
            {
                throw new ArgumentException($"There are no values found by path '{jsonPath}' in JSON file '{resourceName}'");
            }
            return node;
        }
    }
}
