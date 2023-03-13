using System;

class Program
{
    static void Main(string[] args)
    {
        int[] dayOfWeekMenuLimit = { 0, 5, 0, 0, 0, 2, 2 };
        int[] timeOfDayMenuLimit = { 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 0 }; 
        int[] menuCount = { 0, 5, 3, 2 }; 
        string[] menuNames = { "", "Breakfast Set", "Coffee", "Weekend Set" }; 

        while (true)
        {
            Console.Write("Enter the day of the week (1 to 7): ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the time of day (8 to 18): ");
            int timeOfDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the menu you want to order: ");
            string menuName = Console.ReadLine();

            if (menuName == "End")
            {
                break; 
            }

            int menuIndex = Array.IndexOf(menuNames, menuName);

            if (menuIndex == -1)
            {
                Console.WriteLine("Please enter a valid menu."); 
            }
            else if (menuCount[menuIndex] == 0)
            {
                Console.WriteLine("Sorry your order is out of stock."); 
            }
            else if ((menuIndex == 1 && timeOfDay > 11) || (menuIndex == 3 && dayOfWeek < 6))
            {
                Console.WriteLine("Sorry your order is not available."); 
            }
            else if (dayOfWeekMenuLimit[dayOfWeek] == 0 || timeOfDayMenuLimit[timeOfDay] == 0)
            {
                Console.WriteLine("Sorry your order is out of stock."); 
            }
            else
            {
                menuCount[menuIndex]--;
                dayOfWeekMenuLimit[dayOfWeek]--;
                timeOfDayMenuLimit[timeOfDay]--;
                Console.WriteLine("Your order for {0} has been placed.", menuName);
            }
        }
    }
}
