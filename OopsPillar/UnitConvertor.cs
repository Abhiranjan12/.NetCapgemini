using System;
class UnitConvertor{
    public double Convert(double value,string fromUnit,string toUnit){
        // agr length rhe tho
        if(fromUnit=="M" && toUnit=="K") return value*0.001;
        else if(fromUnit=="K" && toUnit=="M") return value*1000;
        else if(fromUnit=="M" && toUnit=="F") return value*5280;
        else if(fromUnit=="F" && toUnit=="M") return value*1/5280;
        //= agr width re tho
        else if(fromUnit=="G" && toUnit=="K") return value*0.001;
        else if(fromUnit=="K" && toUnit=="G") return value*1000;
        else if(fromUnit=="P" && toUnit=="O") return value*16;
        else if(fromUnit=="O" && toUnit=="P") return value*1/16;

        // agr temprature ho
        else if(fromUnit=="C" && toUnit=="F") return (value*9/5)+32;
        else if(fromUnit=="F" && toUnit=="C") return (value-32)*5/9;
        else if(fromUnit=="C" && toUnit=="K") return value+273.15;
        else if(fromUnit=="K" && toUnit=="C") return value-273.15;
        else return 0.0;
    }
    public double Convert(double value,string fromUnit){
        if(fromUnit=="M") return value*0.001;
        else if(fromUnit=="M") return value*5280;
        else if(fromUnit=="G") return value*0.001;
        else if(fromUnit=="P") return value*16;
        else if(fromUnit=="C") return value*9/5+32;
        else if(fromUnit=="C") return value+273.15;
        else return 0.0;
    }
}
// class Program{
//     public static void Main(string[] args){
//         double value;
//         string ch,fromUnit,toUnit;
//         Console.WriteLine("Enter the case: ");
//         ch=Console.ReadLine();
//         UnitConvertor u=new UnitConvertor();
//         switch(ch){
//             case "Length":
//             Console.Write("Enter the Value: ");
//             value=double.Parse(Console.ReadLine());
//             Console.Write("Enter fromUnit: ");
//             fromUnit=Console.ReadLine();
//             Console.Write("Enter toUnit: ");
//             toUnit=Console.ReadLine();
//             Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
//             Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
//             break;
//             case "Width":
//             Console.Write("Enter the Value: ");
//             value=double.Parse(Console.ReadLine());
//             Console.Write("Enter fromUnit: ");
//             fromUnit=Console.ReadLine();
//             Console.Write("Enter toUnit: ");
//             toUnit=Console.ReadLine();
//             Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
//             Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
//             break;
//             case "Temp":
//             Console.Write("Enter the Value: ");
//             value=double.Parse(Console.ReadLine());
//             Console.Write("Enter fromUnit: ");
//             fromUnit=Console.ReadLine();
//             Console.Write("Enter toUnit: ");
//             toUnit=Console.ReadLine();
//             Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
//             Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
//             break;
//             default:
//             Console.WriteLine("Error from unit");
//             break;
//         }
//     }
// }
// using System;
// class UnitConvertor{
//     public double Convert(double value,string fromUnit,string toUnit){
//         // agr length rhe tho
//         if(fromUnit=="M" && toUnit=="K") return value*0.001;
//         else if(fromUnit=="K" && toUnit=="M") return value*1000;
//         else if(fromUnit=="M" && toUnit=="F") return value*5280;
//         else if(fromUnit=="F" && toUnit=="M") return value/5280;
//         // agr width re tho
//         else if(fromUnit=="G" && toUnit=="K") return value*0.001;
//         else if(fromUnit=="K" && toUnit=="G") return value*1000;
//         else if(fromUnit=="P" && toUnit=="O") return value*16;
//         else if(fromUnit=="O" && toUnit=="P") return value/16.0;

//         // agr temprature ho
//         else if(fromUnit=="C" && toUnit=="F") return (value*9/5)+32;
//         else if(fromUnit=="F" && toUnit=="C") return (value-32)*5/9;
//         else if(fromUnit=="C" && toUnit=="K") return value+273.15;
//         else if(fromUnit=="K" && toUnit=="C") return value-273.15;
//         else return 0.0;
//     }

//     public double Convert(double value,string fromUnit){
//         if(fromUnit=="M") return value*0.001;
//         else if(fromUnit=="M") return value*5280;
//         else if(fromUnit=="G") return value*0.001;
//         else if(fromUnit=="P") return value*16;
//         else if(fromUnit=="C") return value*9/5+32;
//         else if(fromUnit=="C") return value+273.15;
//         else return 0.0;
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         double value;
//         string ch,fromUnit,toUnit;
//         Console.WriteLine("Enter the case: ");
//         ch=Console.ReadLine();
//         UnitConvertor u=new UnitConvertor();
//         switch(ch){
//             case "Length":
//             Console.Write("Enter the Value: ");
//             value=double.Parse(Console.ReadLine());
//             Console.Write("Enter fromUnit: ");
//             fromUnit=Console.ReadLine();
//             Console.Write("Enter toUnit: ");
//             toUnit=Console.ReadLine();
//             Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
//             Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
//             break;

//             case "Width":
//             Console.Write("Enter the Value: ");
//             value=double.Parse(Console.ReadLine());
//             Console.Write("Enter fromUnit: ");
//             fromUnit=Console.ReadLine();
//             Console.Write("Enter toUnit: ");
//             toUnit=Console.ReadLine();
//             Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
//             Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
//             break;

//             case "Temp":
//             Console.Write("Enter the Value: ");
//             value=double.Parse(Console.ReadLine());
//             Console.Write("Enter fromUnit: ");
//             fromUnit=Console.ReadLine();
//             Console.Write("Enter toUnit: ");
//             toUnit=Console.ReadLine();
//             Console.WriteLine("The conversion of fromUnit to toUnit is: "+u.Convert(value,fromUnit,toUnit));
//             Console.WriteLine("The conversion of fromUnit to defaultUnit: "+u.Convert(value,fromUnit));
//             break;

//             default:
//             Console.WriteLine("Error from unit");
//             break;
//         }
//     }
// }
