namespace Day17
{
    public class predicateExample
    {
        public predicateExample()
        {
            Predicate<int> isEven = number => number % 2 == 0; // predicate always stores boolean value as output 

            bool check = isEven(10); // returns true;
            
        }
    }
}