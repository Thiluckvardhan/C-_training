namespace Day18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Question1
            System.Console.WriteLine("---------------------------------------------------QUESTION1-----------------------------------------------------------");
            Question1 p = new();
            Console.Write("Enter Sold Count to check: ");
            long soldCount;
            if (long.TryParse(Console.ReadLine(), out soldCount))
            {
                var result = p.FindItemDetails(soldCount);
                if (result.Count == 0)
                {
                    Console.WriteLine("Invalid Sold Count");
                }
                else
                {
                    Console.WriteLine($"Items with sold Count {soldCount}:");
                    foreach (var item in result)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Enter correct Sold Count");
            }
            Console.WriteLine("---------------------Min and Max-----------------------------");
            var list = p.FindMinandMaxSoldItems();
            if (list.Count == 0)
            {
                Console.WriteLine("NO Elements in the Sorted Dictinoray");
            }
            else
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("------------------------Sorted by count -----------------------");
            var dictionary = p.SortByCount();
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            #endregion

            #region Question2
            System.Console.WriteLine("---------------------------------------------------QUESTION2-----------------------------------------------------------");
            Question2 question2 = new();
            question2.AddMovie("Inception,Nolan,Sci-Fi,9");
            question2.AddMovie("Interstellar,Nolan,Sci-Fi,8");
            question2.AddMovie("Titanic,Cameron,Romance,7");
            question2.AddMovie("Avatar,Cameron,Sci-Fi,8");
            question2.AddMovie("Joker,Phillips,Drama,9");

            System.Console.WriteLine("-------------Movie Search-------------");
            Console.Write("Enter Genre to Search Movie: ");
            string? genre = Console.ReadLine();

            var genrelist = question2.viewMoviesByGenre(genre);

            foreach (var item in genrelist)
            {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine("----------Movies By Rating order------------------");
            var ratinglist = question2.ViewMoviesByRatings();
            foreach (var item in ratinglist)
            {
                Console.WriteLine($"{item.Title} - {item.Ratings}");
            }
            #endregion

            #region Question3
            System.Console.WriteLine("---------------------------------------------------QUESTION3-----------------------------------------------------------");
            Question3 question3 = new();

            question3.AddNumber(8);
            question3.AddNumber(7);
            question3.AddNumber(9);
            question3.AddNumber(6);
            question3.AddNumber(8);

            double gpa = question3.GetGPAScored();
            if (gpa == -1)
            {
                Console.WriteLine("Numbers list is empty");
            }
            else
            {
                Console.WriteLine(gpa);
            }

            char grade = question3.GetGradeScored(gpa);
            if (grade == '\0')
            {
                Console.WriteLine("Invalid Grade");
            }
            else
            {
                Console.WriteLine(grade);
            }
            #endregion

            #region Question4

            System.Console.WriteLine("---------------------------------------------------QUESTION4-----------------------------------------------------------");
            Question4 q4 = new Question4();

            // Hard-coded yoga members
            q4.AddYogaMember(101, 25, 70, 1.70, "");
            q4.AddYogaMember(102, 30, 85, 1.65, "");
            q4.AddYogaMember(103, 35, 95, 1.60, "");

            // Calculate BMI
            double bmi1 = q4.CalculateBMI(101);
            Console.WriteLine($"Member 101 BMI: {bmi1}");

            double bmi2 = q4.CalculateBMI(102);
            Console.WriteLine($"Member 102 BMI: {bmi2}");

            double bmi3 = q4.CalculateBMI(103);
            Console.WriteLine($"Member 103 BMI: {bmi3}");

            // Calculate Yoga Fee
            Console.WriteLine($"Member 101 Fee: {q4.CalculateYogaFee(101)}");
            Console.WriteLine($"Member 102 Fee: {q4.CalculateYogaFee(102)}");
            Console.WriteLine($"Member 103 Fee: {q4.CalculateYogaFee(103)}");

            #endregion

            #region Question5

            System.Console.WriteLine("---------------------------------------------------QUESTION5-----------------------------------------------------------");
            // success case 
            try
            {
                Question5 q5 = new Question5();

                EcommerceShop shop = q5.Makepayment("Emily", 5000, 2000);

                Console.WriteLine("Payment successful");
            }
            catch (Question5.InsufficientWalletBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //exception catching case
            try
            {
                Question5 q5 = new Question5();

                EcommerceShop shop = q5.Makepayment("Emily", 1000, 2500);

                Console.WriteLine("Payment successful");
            }
            catch (Question5.InsufficientWalletBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Question6
            System.Console.WriteLine("---------------------------------------------------QUESTION6-----------------------------------------------------------");
            //Sucess case 
            try
            {
                Question6 q6 = new Question6();

                User u = q6.ValidatePassword("Thiluck", "admin123", "admin123");

                Console.WriteLine("Password validated");
            }
            catch (PasswordMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Fail Case

            try
            {
                Question6 q6 = new Question6();

                User u = q6.ValidatePassword("Thiluck", "admin123", "admin124");

                Console.WriteLine("Password validated");
            }
            catch (PasswordMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Question7
            System.Console.WriteLine("---------------------------------------------------QUESTION7-----------------------------------------------------------");
            //Success Case
            try
            {
                Question7 q7 = new Question7();

                EstimateDetails e1 = q7.ValidateConstructionEstimate(1200f, 1500f);

                Console.WriteLine("Construction Estimate Approved");
                Console.WriteLine($"{e1.ConstructionArea} {e1.SiteArea}");
            }
            catch (Question7.EstimateException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Exception case
            try
            {
                Question7 q7 = new Question7();

                EstimateDetails e2 = q7.ValidateConstructionEstimate(1800f, 1500f);

                Console.WriteLine("Construction Estimate Approved");
                Console.WriteLine($"{e2.ConstructionArea} {e2.SiteArea}");
            }
            catch (Question7.EstimateException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion
            #region Question8
            System.Console.WriteLine("---------------------------------------------------QUESTION8-----------------------------------------------------------");
            //success case
            try
            {
                Question8 question8 = new();
                Users u = question8.ValidatePhoneNumber("Thiluck", "8885619995");
                Console.WriteLine("User created successfully correct Phone numebr");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //throw case
            try
            {
                Question8 question8 = new();
                Users u = question8.ValidatePhoneNumber("Divyansh", "93923060");
                Console.WriteLine("User created successfully correct Phone numebr");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion
        }
    }
}