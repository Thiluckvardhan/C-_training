namespace Day18
{
    public class Question3
    {
        public static List<int> NumberList = new();
        public void AddNumber(int Numbers)
        {
            NumberList.Add(Numbers);
        }

        public double GetGPAScored()
        {
            if (NumberList.Count == 0)
            {
                return -1;
            }

            return (NumberList.Sum(n => n*3))/(NumberList.Count()*3);
        }

        public char GetGradeScored(double gpa)
        {
            if(gpa<5 || gpa > 10)
            {
                return '\0';
            }
            else if (gpa == 10)
            {
                return 'S';
            }
            else if (9 <= gpa)
            {
                return 'A';
            }
            else if (8 <= gpa)
            {
                return 'B';
            }
            else if (7 <= gpa)
            {
                return 'C';
            }
            else if (6 <= gpa)
            {
                return 'D';
            }
            else if (5 <= gpa)
            {
                return 'E';
            }
            return '\0';
        }
    }
}