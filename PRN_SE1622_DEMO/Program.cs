Main();
static void Main()
{
    int x = 1;
    int y = 2;  
    void ShowValue(int x)
    {
        Console.WriteLine($"x = {x}, a={a}");
        x = 10;
    }
    ShowValue(x); 
    Console.WriteLine(x);
}
