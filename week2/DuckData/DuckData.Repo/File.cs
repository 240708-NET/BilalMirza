using DuckData.Models;


namespace DuckData.Repo
{
    public class FileReadWrite : IRepository
    {

                //If file path doesnt exist, create file and paste text, else file path does exist, read contents in file
        public void ReadAndWriteWithFile (string path)
        {
            string text = "Some content for the file";
            if (!File.Exists(path)) // If file path doesnt exist, create file and paste text
            {
                File.WriteAllText(path,text);
            }
            else
            {
                Console.WriteLine("Reading from the file with File.ReadAllText: ");
                text = File.ReadAllText(path);
                Console.WriteLine(text);
            }
        }

        public void StreamReaderReadLine(string path)
        {
        /*
        streamreader does not load the file, it provides a route to the file.
        rather than retrieving the entire file to memory, we can read each line out at 
        a time, to reduce memory allocation.
        */
        StreamReader sr = new StreamReader(path); //resets position since .ReadToEnd goes from current position in file to end
        string text = "";
        Console.WriteLine("Reading from the file with StreamReader (line by line): ");
            while ( (text = sr.ReadLine()) != null)
            {
                Console.Write(text);
                Console.WriteLine( " -- " );
            }
            sr.Close();
        }

        public void StreamReaderReadToEnd ( string path)
        {
            StreamReader sr = new StreamReader(path); //resets position since .ReadToEnd goes from current position in file to end
            string text = "";
            Console.WriteLine("Reading from the file with StreamReader (EOF): ");
            while ( (text = sr.ReadToEnd()) != "")
            {
                Console.Write(text);
                Console.WriteLine( " -- " );
            }
            sr.Close();
        }

        public List<Duck> ReadDucksFromFile(string path)
        {
            StreamReader sr = new StreamReader (path);
            List<Duck> duckList = new List<Duck>();
            string text = "";

            while ( (text = sr.ReadLine()) != null)
            {
                string[] duckVals = text.Split(' ');
                Duck mySavedDuck = new Duck (int.Parse(duckVals[0]), duckVals[1], int.Parse(duckVals[2]));
                duckList.Add(mySavedDuck);
            }
            sr.Close();
            return duckList;
        }
        void SaveDuck(Duck myDuck, string path)
        {
        }

        void SaveAllDucks(List<Duck> duckList, string path)
        {
        }
    
    }
}