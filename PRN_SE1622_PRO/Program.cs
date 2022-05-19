namespace fptedu.se1622;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine($"Hello, World....");

        Console.WriteLine($"Enter value x and y: ");
        int x= int.Parse(Console.ReadLine());
        int y= int.Parse(Console.ReadLine());   
        int name;
        var salary = 100.5;
        
        dynamic age = 20; //int32
        age = true;//bool
        Console.WriteLine($"Total of a ={x} and b={y} is {Sum(x, y)}");
        Console.ReadLine();
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}