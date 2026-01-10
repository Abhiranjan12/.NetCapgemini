using System.Transactions;

class Shape
{
    public virtual double CalculateArea()
    {
        
    }
}
class Rectangle: Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    public override double CalculateArea(int length,int breath)
    {
        return length*breath;
    }
}
class Circle: Shape
{
    public double radius;
    public Circle(double radius)
    {
        this.radius=radius;
    }
    public override double CalculateArea(int radius)
    {
        return 22/7*radius*radius
    }
}
class Progam
{
    public static void Main(string[] args)
    {
        int n;
        Console.Write("Enter the value of n: ");
        n=int.Parse(Console.ReadLine());
        string[] arr=new string[n];
        for(int i = 0; i < n; i++)
        {
            arr[i]=Console.ReadLine();
            if (arr[i] == "Recatange" && n>0)
            {
                double l=double.Parse(Console.ReadLine());
                double b=double.Parse(Console.ReadLine());
                Rectangle r=new Rectangle();
                Console.WriteLine(r.CalculateArea(l,b));
            }
            else if(arr[i]=="Circle" && n>0)
            {
                double r=double.Parse(Console.ReadLine());
                Circle c=new Circle();
                Console.WriteLine(c.CalculateArea(r));
            }
            else
            {
                Console.WriteLine("ENter the valid shape");
            }
        }
    }
}