using Models;
using System;
using Utilities;
namespace StatusTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usernamei daxil edin: ");
            string username = Console.ReadLine();
            User user = new User(username);
            string answer = "";
            do
            {
                Console.WriteLine("====Menu======");
                Console.WriteLine("1.Share status" +
                                  "\n2.Get all statuses" +
                                  "\n3.Get status by id" +
                                  "\n4.Filter status by date" +
                                   "\n0.Quit");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("Statusun bashligini yazin: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Statusun contentini yazin: ");
                    string content = Console.ReadLine();
                    Status status = new Status(title, content);
                    user.Statuses.Add(status);
                }
                else if (answer == "2")
                {
                    user.GetAllStatuses();
                }
                else if (answer == "3")
                {
                    user.GetStatusById(1).GetStatusInfo();
                }
                else if (answer == "4")
                {
                    foreach (var item in user.FilterStatusByDate(new DateTime(2022, 4, 12)))
                    {
                        item.GetStatusInfo();
                    }
                }

            } while (answer != "0");
        }
    }
}
