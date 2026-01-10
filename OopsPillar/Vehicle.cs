using System;
class Vehicle{
    protected double distance;
    protected double hour;
    protected double fuel;
    public Vehicle(double distance,double hour,double fuel){
        Console.WriteLine("This is base class constructor");
        this.distance=distance;
        this.hour=hour;
        this.fuel=fuel;
    }
    public void Average(){
        double avg=distance/fuel;
        Console.WriteLine("the avg of vehicle is: "+avg);
    }
    public virtual void Speed(){
        double speed=distance/hour;
        Console.WriteLine("the Speed of vehicle is: "+speed);
    }
}
class Car:Vehicle{
    //:base(distance,hour,fuel)
    
    public Car(double distance,double hour,double fuel):base(distance,hour,fuel){
        Console.WriteLine("This is  child class constructor");
    }
    public new void Average(){
        double avg=distance/fuel;
        Console.WriteLine("the avg of vehicle is: "+avg);
    }
    public override void Speed(){
        double speed=distance/hour;
        Console.WriteLine("the Speed of vehicle is: "+speed);
    }
}