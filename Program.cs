namespace EnumCalendar
{
    enum Months
    {
        Close,
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class Program
    {
        static void Main()
        {
            bool loop = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose a month:" +
                "\n1. January" +
                "\n2. February" +
                "\n3. March" +
                "\n4. April" +
                "\n5. May" +
                "\n6. June" +
                "\n7. July" +
                "\n8. August" +
                "\n9. September" +
                "\n10. October" +
                "\n11. November" +
                "\n12. December" +
                "\n\n0. Exit");
                int select = int.Parse(Console.ReadLine());
                Months selectedMonth = (Months)select;
                switch (selectedMonth)
                {
                    case Months.January:
                        Console.WriteLine("The year begins!");
                        Console.ReadKey();
                        break;
                    case Months.February:
                        Console.WriteLine("Valentines!");
                        Console.ReadKey();
                        break;
                    case Months.March:
                        Console.WriteLine("March marks the begining of the spring");
                        Console.ReadKey();
                        break;
                    case Months.April:
                        Console.WriteLine("Easter");
                        Console.ReadKey();
                        break;
                    case Months.May:
                        Console.WriteLine("Labour day");
                        Console.ReadKey();
                        break;
                    case Months.June:
                        Console.WriteLine("Summer!");
                        Console.ReadKey();
                        break;
                    case Months.July:
                        Console.WriteLine("Vacations");
                        Console.ReadKey();
                        break;
                    case Months.August:
                        Console.WriteLine("Back to school!");
                        Console.ReadKey();
                        break;
                    case Months.September:
                        Console.WriteLine("Fall is here");
                        Console.ReadKey();
                        break;
                    case Months.October:
                        Console.WriteLine("Spooky");
                        Console.ReadKey();
                        break;
                    case Months.November:
                        Console.WriteLine("Nothing but darkness");
                        Console.ReadKey();
                        break;
                    case Months.December:
                        Console.WriteLine("Christmas");
                        Console.ReadKey();
                        break;
                    case Months.Close:
                        loop = false;
                        break;
                    default:
                        break;
                }
            } while (loop);
        }
    }
}