using System; 

class Program
{
    public static void Main(string[] args)
    {
       Car audi =new Car("a11",200,true);
        

    }
}
class Car
{
    string model;
    int speed;
    bool disc;

    public Car(string model, int speed, bool disc)
    {
        this.model = model;
        this.speed = speed;
        this.disc = disc;
        Console.WriteLine($"The model name is audi{model} and speed of the car is {speed} and disc or not {disc}");
    }
     
}