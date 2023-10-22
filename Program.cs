using System.Threading.Channels;

namespace home_FLASH
{
    internal class Program
    {
        public delegate void Functions();
        static void Main(string[] args)
        {
            PriceList list = new PriceList();
            Functions[] menu = new Functions[5] { list.AddNewStorage, list.DeleteStorage, list.PrintList, list.EditStorage, list.FindStorage };

            while (true)
            {
                Console.WriteLine("0 - Add new storage");
                Console.WriteLine("1 - Delete storage");
                Console.WriteLine("2 - Print list of storages");
                Console.WriteLine("3 - Edit storage");
                Console.WriteLine("4 - Find storage");
                Console.WriteLine("5 - Exit");

                string input = Console.ReadLine();
                int selected = String.IsNullOrWhiteSpace(input) ? 5 :Convert.ToInt32(input);

                if (selected == 5) break;
                else menu[selected]();
            }
        }
    }
}