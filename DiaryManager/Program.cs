using System;
using System.Globalization;

namespace DiaryManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\Diary.txt";
            Console.WriteLine("Welcome to your diary :) \n");

            DailyDiary dailyDiary = new DailyDiary();
            string service;
            int serviceValue;

            do
            {
                Console.WriteLine("What service would you like to have? \n1-Read whole Diary   2-Retrieve by date   3-Add entry   4-Delete entry   5-Check number of lines   6-Exit \n");
                Console.WriteLine("Write the number of each service to choose :) \n");

                service = Console.ReadLine();
                bool testService = int.TryParse(service, out serviceValue);

                if (!testService || serviceValue < 1 || serviceValue > 6)
                {
                    Console.WriteLine("Invalid input, please try again!\n");
                    continue;
                }

                switch (service)
                {
                    case "1":
                        Console.WriteLine(dailyDiary.ReadAll(path));
                        break;

                    case "2":
                        Console.WriteLine("Enter date (YYYY-MM-DD): \n");
                        string date2;
                        while (true)
                        {
                            date2 = Console.ReadLine();
                            if (IsValidDate(date2))
                                break;
                            else
                                Console.WriteLine("Invalid date format, please enter a valid date (YYYY-MM-DD): \n");
                        }
                        dailyDiary.Readcontent(date2, path);
                        break;

                    case "3":
                        string date3, content3;
                        Console.WriteLine("Enter date (YYYY-MM-DD): \n");
                        while (true)
                        {
                            date3 = Console.ReadLine();
                            if (IsValidDate(date3))
                                break;
                            else
                                Console.WriteLine("Invalid date format, please enter a valid date (YYYY-MM-DD): \n");
                        }
                        Console.WriteLine("Enter content: \n");
                        while (true)
                        {
                            content3 = Console.ReadLine();
                            if (!string.IsNullOrEmpty(content3))
                                break;
                            else
                                Console.WriteLine("Content cannot be empty, please enter valid content: \n");
                        }
                        dailyDiary.Addcontent(date3, content3, path);
                        break;

                    case "4":
                        string date4;
                        Console.WriteLine("Enter date (YYYY-MM-DD) to delete: \n");
                        while (true)
                        {
                            date4 = Console.ReadLine();
                            if (IsValidDate(date4))
                                break;
                            else
                                Console.WriteLine("Invalid date format, please enter a valid date (YYYY-MM-DD): \n");
                        }
                        dailyDiary.Deletecontent(date4, path);
                        break;

                    case "5":
                        Console.WriteLine(dailyDiary.count_lines(path));
                        break;

                    case "6":
                        Console.WriteLine("Exiting...\n");
                        return;
                }

                string answer;
                
                    Console.WriteLine("Would you like to have another service? (yes/no) \n");
                    answer = Console.ReadLine().ToLower();
                 while (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Invalid input try again :< \n");
                    Console.WriteLine("Would you like to have another service? (yes/no) \n");
                    answer = Console.ReadLine().ToLower();

                }

                if (answer != "yes")
                    break;

            } while (true);

            Console.WriteLine("Thank you for using My diary until next time :) \n");
        }

        private static bool IsValidDate(string date)
        {
            DateTime tempDate;
            return DateTime.TryParse(date, out tempDate) && date.Length == 10 && date[4] == ('-') && date[7] == '-';

        }

    }
}
