// using System;
// using System.IO;
// class Fileclass
// {
//     public void ReadData()
//     {
//         using (FileStream fileStream = new FileStream(@"C:\data\Text.txt", FileMode.Open, FileAccess.Read))
//         using (StreamReader streamReader = new StreamReader(fileStream))
//         {
//             string str;
//             while ((str = streamReader.ReadLine()) != null)
//             {
//                 Console.WriteLine(str);
//             }
//         }
//     }
//     public void ReadData()
//     {
//         FileStream fileStream = new FileStream("C:\data\Text.txt", FileMode.Open, FileAccess.Read);
//         StreamReader streamReader = new StreamReader(fileStream);
//         streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

//         string str = streamReader.ReadLine();
//         while (str != null)
//         {
//             Console.WriteLine(str);
//             str = streamReader.ReadLine();
//         }
//     }
//     public void Writetext()
//     {
//         FileStream fi = new FileStream("C:\data\Text.txt", FileMode.Open, FileAccess.Write);
//         StreamWriter str = new StreamWriter(fi);
//         Console.WriteLine("Enter some text");
//         string str1 = Console.ReadLine();
//         str.WriteLine(str1);
//         str.Close();
//         fi.Close();
//     }

//     public static void Main(String[] args)
//     {
//         Fileclass fi=new Fileclass();
//         fi.Writetext();
//         fi.ReadData();
//     }
// }


// class BinaryWriteExample
// {
//     public static void Main(string[] args)
//     {
//         string filepath="Employe.dat";
//         using(FileStream fs=new FileStream(filepath,FileMode.Create))
//         using(BinaryWriter bi=new BinaryWriter(fs))
//         {
//             bi.Write(101);
//             bi.Write("Abhi");
//             bi.Write(2839300.0887);
//             bi.Write(true);
//         }
//         Console.WriteLine("File created sucessfully");
//     }
// }
// using System;
// using System.IO;

// class BinaryReadExample
// {
//     public static void Main(string[] args)
//     {
//         string pathname = "Employe.dat";
//         using (FileStream fs = new FileStream(pathname, FileMode.Open))
//         using (BinaryReader br = new BinaryReader(fs))
//         {
//             int id = br.ReadInt32();
//             string name = br.ReadString();
//             double salary = br.ReadDouble();
//             bool isActive = br.ReadBoolean();
//             Console.WriteLine("Employee Id is: " + id);
//             Console.WriteLine("Employee Name is: " + name);
//             Console.WriteLine("Employee Salary is: " + salary);
//             Console.WriteLine("Employee is Active or not: " + isActive);
//         }
//     }
// }

using System;
using System.IO;
class FileInfoExample
{
    public static void Main(string[] args)
    {
        // 1. Create file using File class
        string pathname = "Employee.txt";
        using (FileStream fs = File.Create(pathname))
        {
            Console.WriteLine("File created successfully using File class");
        }

        // 2. Create and write text using FileInfo
        FileInfo fi = new FileInfo("MyTestfile.txt");
        using (StreamWriter sw = fi.CreateText())
        {
            sw.WriteLine("This is a text file created using FileInfo class.");
            Console.WriteLine("Text written to file using FileInfo");
        }
        // 3. Delete the file
        fi.Delete();
        Console.WriteLine("File has been deleted");

        // 4. Copy file using FileInfo
        string sourcePath = "Employee.txt";
        string destinationPath = "File.txt";
        FileInfo fiSource = new FileInfo(sourcePath);
        if (fiSource.Exists)
        {
            fiSource.CopyTo(destinationPath, true);
            Console.WriteLine("File is copied successfully");
        }
        else
        {
            Console.WriteLine("Source file does not exist");
        }
        string sourcePath1 = "Employee.txt";
        string destinationPath1 = "File.txt";
        FileInfo fiSource1 = new FileInfo(sourcePath1);
        if (fiSource1.Exists)
        {
            fiSource1.MoveTo(destinationPath1, true);
            Console.WriteLine("File is moved successfully");
        }
        else
        {
            Console.WriteLine("Source file does not exist");
        }
        FileInfo fi4 = new FileInfo("MyTestfile.txt");

        using (StreamWriter sw = fi4.AppendText())
        {
            sw.WriteLine("This line is appended to the file.");
            sw.WriteLine("Another appended line.");
        }
        Console.WriteLine("Data appended successfully.");

        FileInfo fi5 = new FileInfo("MyTestfile.txt");
        using (StreamReader sr = fi5.OpenText())
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            
        }
        FileInfo fi6=new FileInfo("MyTestFile.txt");
        Console.WriteLine("file name is: "+fi.Name);
        Console.WriteLine("file creation time is : "+fi.CreationTime.ToLongTimeString());
        Console.WriteLine("file lastaccesstime is: "+fi.LastAccessTime.ToLongDateString());
        Console.WriteLine("file length is: "+fi.Length.ToString()+ " bytes");
        Console.WriteLine("file extension is: "+fi.Extension);
        Console.WriteLine("file exist or not: "+fi.Exists);
    }

}
