namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int StartYear = 0;
            int EndYear = 0;
            int difference = 0;
            bool validChoice = false;
            do
            {
                Console.WriteLine("Enter start year");
                StartYear = Convert.ToInt32(Console.ReadLine());   
                Console.WriteLine("Enter end year");
                EndYear = Convert.ToInt32(Console.ReadLine());
                if (StartYear > EndYear)
                {
                    Console.WriteLine("Start year must be before end year");
                }
                else
                {
                    if (StartYear > 2000)
                    {
                        Console.WriteLine("Start year must be before 200");
                    }
                    else
                    {
                        validChoice = true;
                    }
                }

            } while (validChoice);
            difference = EndYear - StartYear;
        }
    }
}
