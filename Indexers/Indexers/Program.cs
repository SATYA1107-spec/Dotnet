using System;

class Cars
{
    int MNo;
    string MName;
    int Model;
    double price;

    public  Cars (int MNo,string Mname, int Model, double price)
    {
        this.MNo = MNo;
        this.MName = Mname;
        this.Model = Model;
        this.price = price;
    }
    public object this[int index]
    {
        get
        {
            if (index == 0)
                return MNo;
            else if (index == 1)
                return MName;
            else if (index == 2)
                return Model;
            else if (index == 3)
                return price;
            return null;

        }
        set
        {
            if (index == 0)
                MNo = (int)value;
            else if (index == 1)
                MName = (string)value;
            else if (index == 2)
                Model = (int)value;
            else if (index == 3)
                price = (double)value;
        }
    }
    public object this[string name]
    {
        get
        {
            if (name == "Mno")
                return MNo;
            else if (name == "Mname")
                return MName;
            else if (name == "Model")
                return Model;
            else if (name == "Price")
                return price;
            return null;

        }
        set
        {
            if (name == "Mno")
                MNo = (int)value;
            else if (name == "Mname")
                MName = (string)value;
            else if (name == "Model")
                Model = (int)value;
            else if (name == "Price")
                price = (double)value;
        }
    }

}
class Indexersdemo
{
    public static void Main(string[] args)
    {
        Cars c1 = new Cars (123,"XUV",2014,130000);
        Console.WriteLine("Mno : "+c1[0]);
        Console.WriteLine("Mname : "+c1[1]);   
        Console.WriteLine("Model : "+c1[2]);
        Console.WriteLine("Price : "+c1[3]);
        Console.WriteLine("Mno : " + c1[0]);
        Console.WriteLine("\n");
        Console.WriteLine(c1["Mno"]);
        Console.WriteLine(c1["Mname"]);
        Console.WriteLine(c1["Model"]);
        Console.WriteLine(c1["Price"]);


    }
}