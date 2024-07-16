using System;
using System.IO;
using DuckData.Repo;

namespace FileIO
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Reading Files...");
            string path = @"./Ducks.txt";
            string text = "This is some example content for file";

            //IRepository file = new FileReadWrite();
            IRepository file = new Serialization();

            file.ReadAndWriteWithFile(path);

            // Console.WriteLine();
            // file.StreamReaderReadLine(path);

            // Console.WriteLine();
            // file.StreamReaderReadToEnd(path);

            // Console.WriteLine();
            // file.ReadDucksFromFile(path);

            List<Duck> duckList = new List<Duck>();

            Duck myDuck = new Duck( "red", 20);

            file.SaveDuck(myDuck, path);
            duckList.add(myDuck);
            duckList.add(new Duck ("green", 50));
            duckList.add(new Duck ("black", 120));

            file.SaveAllDucks(duckList, path);



            // Duck myDuck = new Duck("purple", 100);
            // myDuck.Quack();
            // Console.WriteLine(myDuck.ToString());
            path = @"./Ducks.txt";
            //File.WriteAllText(path, myDuck.ToString());
            string ducks = File.ReadAllText(path);
            Console.WriteLine(ducks);
            string[] duckVals = ducks.Split(' ');
            Duck mySavedDuck = new Duck (duckVals[0], int.Parse(duckVals[1]));
            mySavedDuck.Quack();

            sr = new StreamReader (path);
            List<Duck> duckList = new List<Duck>();

            while ( (text = sr.ReadLine()) != null)
            {
                duckVals = text.Split(' ');
                mySavedDuck = new Duck ( duckVals[0], int.Parse(duckVals[1]));
                duckList.Add(mySavedDuck);
            }
            sr.Close();

            foreach(Duck d in duckList)
            {
                d.Quack();
            }
        }
    }
}