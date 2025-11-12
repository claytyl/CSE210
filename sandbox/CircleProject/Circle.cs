class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0.0;
        Console.WriteLine("In the default constructor");
    }

    public Circle(double radius)
    {
        SetRadius(radius);
        Console.WriteLine("In the NONdefault constructor");
    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Invalid radius, must >= 0");
            _radius = 0;
        }
        else
        {
            _radius = radius;
        }

    }

    public double GetCircleArea()
    {
    return 3.1415 * _radius * _radius;
    }
}

