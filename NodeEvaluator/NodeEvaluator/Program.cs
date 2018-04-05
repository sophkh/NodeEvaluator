using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeEvaluator
{
    class Program
    {
        private static string json;
        private static string schema;
        private static JSchema schema2;

        static void Main(string[] args)
        {
            Node node = new Node();
            List<Node> nodes = new List<Node>();
            using (TextReader reader = File.OpenText("test.schema.json"))
            {
                schema = reader.ReadToEnd();
                schema2 = JSchema.Parse(schema);
                // do stuff
            }
            using (StreamReader r = new StreamReader("input.json"))
            {
                json = r.ReadToEnd();
                JToken jsontoken = JToken.Parse(json);
                IList<ValidationError> errors;
                bool valid = jsontoken.IsValid(schema2, out errors);
                if (valid)
                {
                    //valid nodes are passed
                    nodes = JsonConvert.DeserializeObject<List<Node>>(json);
                }
                else
                {
                    Console.WriteLine("Invalid data in input file");
                }
            }

            foreach (Node n in nodes)
            {
                NodeStatistics nodestats = new NodeStatistics();
                nodestats.ComputeNode(n);
            }
            Console.ReadLine();
        }
    }
}
