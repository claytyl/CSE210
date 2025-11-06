class Planet
{
    public string _name = "";
    public double _diameter = 0;
    public void DisplayPlanetInformation()
    {
        Console.WriteLine($"The planet name: {_name}, diameter: {_diameter}");
    }
}