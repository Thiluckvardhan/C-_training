namespace Day17
{
    public class FunctionDelegateExample
    {
        public Func<int, int, string> multiplyResult = (x, y) =>
        {
            return $"{x} times {y} is {x * y}";
        };
    }
}