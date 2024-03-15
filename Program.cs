using Microsoft.VisualBasic;

namespace Lab_7_sorted_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SortedList<int, string> computerList = new SortedList<int, string>();
            // add the elements to the sorted list
            computerList.Add(1, "Dell");
            computerList.Add(2, "Gateway");
            computerList.Add(3, "HP");
            computerList.Add(4, "Asus");
            computerList.Add(5, "Acer");
            // display the elements of the sorted list
            Console.WriteLine("The items in the computer list are: ");
            foreach (KeyValuePair<int,string> gl in computerList)
            {
                Console.WriteLine($"Key = {gl.Key}  Value = {gl.Value}");
            }

            Console.WriteLine("What class of computer do you want?");
            int compclass = int.Parse(Console.ReadLine());
            Console.WriteLine("What type of computer do you want?");
            string manufacturer = Console.ReadLine();
            // check for value in list
            if (computerList.ContainsValue(manufacturer.ToString()))
                Console.WriteLine($"{manufacturer} is one of the values in your list");
            else
            {
                // check for country key in list (no doubles)
                if (computerList.ContainsKey(compclass))
                {
                    Console.WriteLine(($"You can only have 1 class of {manufacturer} "));
                    computerList.Remove(compclass);
                    computerList.Add(compclass, manufacturer.ToString());
                    Console.WriteLine($"Your current class is {compclass} has been removed and {manufacturer.ToString()} replaces it.");
                      
                }

                else
                {
                    computerList.Add(compclass, manufacturer);
                    Console.WriteLine($"{compclass}, { manufacturer} was added to your list.");
                }
            }

            Console.WriteLine("The items in the computer list are:");
            foreach(KeyValuePair<int, string> gl in computerList)
            {
                Console.WriteLine(($"Key = {gl.Key}  Value = {gl.Value}"));
            }

        }
    }
}
