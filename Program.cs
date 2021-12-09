using System;

namespace _6lab
{
    class Program
    {
        static string[] namesList = new string[]
           {
            "Павел",
            "Максим",
            "Федор",
            "Алексей",
            "Артем",
            "Степан",
            "Руслан",
           "Андрей",
           "Никита"

           };
        static void Main(string[] args)
        {
            PostOffice postOffice = new PostOffice();
            for (int i = 0; i <= 9; i++) 
            {
                Random random = new Random();
                DateTime dateOfEmployment = new DateTime(random.Next(1990, 2021), random.Next(1, 12), random.Next(1, 28));
                if (i % 3 == 0)
                {
                    postOffice.Employees.Add(new Gashier()
                    {
                        Name = namesList[i],
                        DateOfEmployment = dateOfEmployment
                    });
                }
                else if (i % 3 == 1)
                {
                    postOffice.Employees.Add(new Operator()
                    {
                        Name = namesList[i],
                        DateOfEmployment = dateOfEmployment
                    });
                }
                else
                {
                    postOffice.Employees.Add(new Postman()
                    {
                        Name = namesList[i],
                        DateOfEmployment = dateOfEmployment
                    });
                }              
            }
            postOffice.Poll();
        }
    }
}