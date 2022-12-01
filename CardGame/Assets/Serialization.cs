using Newtonsoft.Json;

namespace CardGame.Assets
{
    public static class Serialization
    {
        public static void serialize<T>(T obj, string filename)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            File.WriteAllText(@$"{filename}.json", JsonConvert.SerializeObject(obj, settings));
        }
        public static T deserialize<T>(string filename)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All, };
            string strJson = "";
            try { strJson = File.ReadAllText(@$"{filename}.json"); }
            catch (System.IO.FileNotFoundException ex) { }
            return JsonConvert.DeserializeObject<T>(strJson, settings); ;
        }
    }
}
