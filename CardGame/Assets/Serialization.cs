using System.IO;
using Newtonsoft.Json;

namespace CardGame.Assets
{
    public static class Serialization
    {
        public static void serialize<T>(T obj, FileInfo file)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            File.WriteAllText(@$"{file.FullName}", JsonConvert.SerializeObject(obj, settings));
        }
        public static T deserialize<T>(FileInfo file)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All, };
            string strJson = "";
            try { strJson = File.ReadAllText(@$"{file.FullName}"); }
            catch (System.IO.FileNotFoundException ex) { }
            return JsonConvert.DeserializeObject<T>(strJson, settings); ;
        }
    }
}
