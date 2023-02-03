using System;

class Program
{    
    static void Main(string[] args)
    {
        int choice = -1;

        while(choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity \n2. Start refliecting activity");
            Console.WriteLine("3. Start listing activity \n4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(choice)
            {
                case 1: 
                    BreathingActivity breath = new BreathingActivity();
                    breath.StartBreathingActivity();
                    break;
                case 2:
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.StartReflectingActivity();
                    break;
                case 3:
                    ListingActivity list = new ListingActivity();
                    list.StartListingActivity();
                    break;
                case 4:
                    break;
            }

        }
    }
}