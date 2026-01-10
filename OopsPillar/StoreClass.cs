using System;
public class Cloth
{
    public int id { get; set; }
    public Cloth(int id)
    {
        this.id = id;
    }
}
public class Women : Cloth
{
    public string size;
    public string materialType;
    public string returnCloth = "YES";
    public Women(int id, string size, string materialType) : base(id)
    {
        this.size = size;
        this.materialType = materialType;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Women Cloth ID: " + id);
        Console.WriteLine("Size: " + size);
        Console.WriteLine("Material Type: " + materialType);
        Console.WriteLine("Return Option within a Week: " + returnCloth);
    }
}
public class Men : Cloth
{
    public string size;
    public string returnCloth = "YES";
    public Men(int id, string size) : base(id)
    {
        this.size = size;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("MEN ID: " + id);
        Console.WriteLine("Size: " + size);
        Console.WriteLine("Return Option within a Week: " + returnCloth);
    }
}
public class Kids : Cloth
{
    public string size;
    public string returnCloth = "NO";
    public Kids(int id, string size) : base(id)
    {
        this.size = size;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("KID Cloth ID: " + id);
        Console.WriteLine("Size: " + size);
        Console.WriteLine("Return Option: " + returnCloth);
    }
}
