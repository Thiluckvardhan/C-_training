namespace Day2
{

    class ValidDateCheck
    {
        public static void IsValid()
        {
            int day = 0, month = 0, year = 0;
            bool valid = true;

            if (year <= 0)
                valid = false;
            else if (month < 1 || month > 12)
                valid = false;
            else
            {
                if (month == 2)
                {
                    bool leap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);

                    if (leap)
                    {
                        if (day < 1 || day > 29)
                        {   
                            valid = false;
                        }
                    }
                    else
                    {
                        if (day < 1 || day > 28)
                        {   
                            valid = false;
                        }
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day < 1 || day > 30)
                    {   
                        valid = false;
                    }
                }
                else
                {
                    if (day < 1 || day > 31)
                        valid = false;
                }
            }
            if (valid)
            {   
                Console.WriteLine("Valid Date");
            }
            else
            {                
                Console.WriteLine("Invalid Date");
            }
        }
    }
}