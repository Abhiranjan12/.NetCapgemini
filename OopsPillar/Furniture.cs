abstract class Furniture{
    // contain concrete and abstract method also
    protected int num;
    protected string color;
    protected int width;
    protected int height;
    public abstract void Accept();
    public abstract void Display();
    public void MyMethod(){
        Console.WriteLine("it is concrete method");
    }

}
class Bookselve:Furniture{
    public override void Accept(){
        Console.WriteLine("Enter the selves: ");
        num=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the color: ");
        color=Console.ReadLine();
        Console.WriteLine("Enter the width: ");
        width=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height: ");
        height=int.Parse(Console.ReadLine());
    }
    public override void Display(){
        Console.WriteLine("No of seleves is: "+num);
        Console.WriteLine("Color is: "+color);
        Console.WriteLine("Width is: "+width);
        Console.WriteLine("Height is: "+height);
    }
}
class Chair:Furniture{
    public override void Accept(){
        Console.WriteLine("Enter the no of char: ");
        num=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the color: ");
        color=Console.ReadLine();
        Console.WriteLine("Enter the width: ");
        width=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height: ");
        height=int.Parse(Console.ReadLine());
    }
    public override void Display(){
        Console.WriteLine("No of seleves is: "+num);
        Console.WriteLine("Color is: "+color);
        Console.WriteLine("Width is: "+width);
        Console.WriteLine("Height is: "+height);
    }
}