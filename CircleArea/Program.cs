namespace CircleArea;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Caluculate radius of a circle");
        Console.Write("Enter Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        
        var area = Math.PI * radius * radius;
        Console.WriteLine($"The area of the circleis {area}");
    }
}
