class Program
{
    
    static void Main()
    {
        Console.WriteLine("Oi como esta voce?");
        Circle myCircle = new Circle();

        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle myCircle2 = new Circle(100);
        Console.WriteLine(myCircle2.GetCircleArea());
    }
}
