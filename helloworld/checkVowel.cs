using System;
class checkVowel{
    public void cheVowel(){
        char ch;
        Console.WriteLine("Enter char: ");
        ch=char.Parse(Console.ReadLine());
        switch(ch){
            case 'a':
            Console.WriteLine("the character "+ch+" is vowel");
            break;
            case 'e':
            Console.WriteLine("the character "+ch+" is vowel");
            break;
            case 'i':
            Console.WriteLine("the character "+ch+" is vowel");
            break;
            case 'o':
            Console.WriteLine("the character "+ch+" is vowel");
            break;
            case 'u':
            Console.WriteLine("the character "+ch+" is vowel");
            break;
            case 'A':
            Console.WriteLine("the character "+ch+" is vowel");
            break;
            case 'E':
            Console.WriteLine("the character "+ch+" is vowel");
            break; 
            case 'I':
            Console.WriteLine("the charcter "+ch+" is vowel");
            break;
            case 'O':
            Console.WriteLine("the character "+ch+" is vowel");
            break;
            case 'U':
            Console.WriteLine("the character "+ch+" is vowel");
            break; 
            default:
            Console.WriteLine("the chara1cter "+ch+" is not vowel");
            break;
        }
    }
    public void stringFunction(){
        string s;
        Console.WriteLine("Enter the string: ");
        s=Console.ReadLine();
        Console.WriteLine("the origional length is: "+s.Length);
        Console.WriteLine("Uppercase letter is: "+s.ToUpper());
    }
    public void swapNo(){
        int num1,num2;
        Console.WriteLine("Enter the No: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the No: ");
        num2=int.Parse(Console.ReadLine());
        Console.WriteLine("Before swap: a = "+num1+" b = "+num2);
        num1=num1+num2;
        num2=num1-num2;
        num1=num1-num2;
        Console.WriteLine("After swap: a = "+num1+" b = "+num2);
    }
}