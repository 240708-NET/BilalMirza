using DuckData.Models;
using System.Text.Json;

namespace DuckData.Repo
{
    public class Serialization : IRepository
    {

        public void ReadWriteWithFile(string path)
        {
        }

        public void StreamReaderReadLine(string path)
        {  
        }

        public void StreamReaderReadToEnd(string path)
        {
        }

        public List<Duck> ReadDucksFromFile(string path)
        {
            return new List<Duck>();
        }
        
        public void SaveDuck(Duck myDuck, string path)
        {
            string serDuck = serializer.Serialize(myDuck);
            File.WriteAllText(serDuck);
        }

        public void SaveAllDucks(List<Duck> duckList, string path)
        {
            string serDucks = serializer.Serialize(duckList);
            File.AppendAllText(serDucks);
        }

        public List<Duck> LoadAllDucks (string path)
        {
            string json = ReadDucksFromFile.RealAllText(path);
            List<Duck> duckList = JsonSerializer.Deserialize<List<Duck>>(json);
            return duckList;
        }

    }

}