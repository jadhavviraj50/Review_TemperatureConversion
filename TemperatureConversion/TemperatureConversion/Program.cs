using Temperatureconversion;

Console.WriteLine("Welcome to temprature Conversion!");
TemperatureCel cel = new();

while (true)
{
    Console.WriteLine("Options : \n1)Celsius To Fahrenheit\n2)Fahrenheit to Celsius");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            cel.TemCel();
            break;
        case 2:
            cel.CelTemp();
            break;
        default:
            Console.WriteLine("Please choose Correct Option");
            break;
    }
}