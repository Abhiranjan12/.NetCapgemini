class Animal{
    public virtual void MakeSound(){
        Console.WriteLine("It can display nay animal sound based on what you give");
    }
}
class Dog:Animal{
    public override void MakeSound(){
        Console.WriteLine("Dogs Barks");
    }
}
class Cat:Animal{
    public override void MakeSound(){
        Console.WriteLine("cat Meow");
    }
}
