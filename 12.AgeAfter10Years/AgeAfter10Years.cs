using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine();
        Console.Write("Write your Birthday: ");
        string userBirthday = Console.ReadLine();
        DateTime birthday;
        int userYearOfBirth;
        int userAge = 0;
        int ageAfter10Years = 0;
        int presentDay = DateTime.Now.Day;
        int presentMonth = DateTime.Now.Month;
        int today = DateTime.Now.Year;
        bool properDate = DateTime.TryParse(userBirthday, out birthday);
        if (properDate)
        {
            string userMonth = userBirthday;
            userBirthday = userBirthday.Substring(0, 2);
            userMonth = userMonth.Substring(3, 2);
            int dayOfBirth = int.Parse(userBirthday);
            int monthOfBirth = int.Parse(userMonth);
            userYearOfBirth = birthday.Year;
            if (presentMonth < monthOfBirth)
            {
                userAge = today - userYearOfBirth - 1;
                ageAfter10Years = userAge + 10;
            }
            if ((presentDay >= dayOfBirth) && (presentMonth >= monthOfBirth))
            {
                userAge = today - userYearOfBirth;
                ageAfter10Years = userAge + 10;
            }
            if ((presentDay < dayOfBirth) && (presentMonth >= monthOfBirth))
            {
                userAge = today - userYearOfBirth - 1;
                ageAfter10Years = userAge + 10;
            }
            Console.WriteLine();
            Console.WriteLine("You are {0} Years old!", userAge);
            Console.WriteLine();
            Console.WriteLine("Your age after 10 Years going to be {0} Years!", ageAfter10Years);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Incorrect age format!");
            Console.WriteLine();
        }
    }
}