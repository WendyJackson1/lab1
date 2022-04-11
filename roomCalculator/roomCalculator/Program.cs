public class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Please enter length of the room");
        string inputOne = Console.ReadLine();
        double length = double.Parse(inputOne);
        Console.WriteLine("Your room is " + length + " in length.");

        Console.WriteLine("Please enter width of the room");
        string inputTwo = Console.ReadLine();
        double width = double.Parse(inputTwo);
        Console.WriteLine("Your room is " + width + " in width.");

        Console.WriteLine("Please enter hight of the room");
        string inputThree = Console.ReadLine();
        double height = double.Parse(inputThree);
        Console.WriteLine("Your room is "+ height + " in height.");

        double perimeter = 2 * (length + width); 
        Console.WriteLine("Your rooms perimeter is " + perimeter);
        double area = width * length;
        Console.WriteLine("Your rooms area is " + area);

        double roomSurface = 2 * (width * length + height * length + height * width);
        Console.WriteLine("Your rooms surface area is " + roomSurface);
        double roomVolume = length * width * height;
        Console.WriteLine("Your rooms volume area is " + roomVolume);

        switch (area)
        {
            case <= 250:
                Console.WriteLine("Your room is a small room.");
                break;
            case >= 650:
                Console.WriteLine("Your room is a large room.");
                break;
            default:
                Console.WriteLine("Your room is a medium room.");
                break;

        }
    }
}
