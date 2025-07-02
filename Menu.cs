namespace Carrareo;

public class Menu
{
    Dictionary<string, List<string>> car = new Dictionary<string, List<string>>();

    public Menu()
    {
        Console.WriteLine("****************************************");
        Console.WriteLine("Welcome to the Carrareo!");
        Console.WriteLine("Your system to management fleets");
        Console.WriteLine("****************************************\n");
    }

    public void run()
    {
        int iterator = 0;

        do
        {
            Console.WriteLine("*************************");
            Console.WriteLine("MENU");
            Console.WriteLine("1. Add a Car");
            Console.WriteLine("2. See cars");
            Console.WriteLine("0. List all cars");
            Console.WriteLine("*************************");
            
            iterator = Convert.ToInt32(Console.ReadLine());
            
            switch (iterator)
            {
                case 0:
                    
                    Console.WriteLine("Bye");
                    
                    break;
                
                case 1:
                    
                    this.addCar();
                    
                    break;
                
                default:
                    
                    Console.WriteLine("Command invalid, please try again");

                    break;
            }
            
        } while (iterator != 0);
    }

    public void addCar()
    {
        Console.Clear();
        Console.WriteLine("Type the car's branch");
        
        string carBranch = Console.ReadLine();
        
        car.Add(carBranch, new List<string>());
        
        Console.WriteLine($"Please, type the car's model to the branch {carBranch}");
    }
}