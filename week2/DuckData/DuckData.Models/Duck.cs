namespace DuckData.Models

public class Duck
{
    // Fields
    public int ID {get; set;}
    public string color {get; set;}
    public int numFeathers {get; set;}
    private static int IDCounter = 0; // each new duck

    //Constructors
    public Duck (int id, string color, int feathers)
    {
        this.ID = id;
        this.color = color;
        this.numFeathers = feathers;
    }

    public Duck(string color, int feathers) // *** Overloaded ***
    {
        this.color = color;
        this.numFeathers = feathers;
        this.ID = IDCounter++;
    }

    // Methods
    public void Quack()
    {
        Console.WriteLine("Quack! I'm {0}.", this.color );
    }

    public string ToString()
    {
        return string.Format("{0} {1} {2}", this.ID, this.color, this.numFeathers);
    }


}