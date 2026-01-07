namespace Day12
{

    public delegate int delegateAddFuncName(int a, int b);
    public class Delegate
    {

        public void Delegation()
        {
            delegateAddFuncName delegatevar = new delegateAddFuncName(AddMethod);
            Console.WriteLine(delegatevar(50, 25));

            delegatevar = DeleteMethod;
            Console.WriteLine(delegatevar(50, 25));
        }

        public int AddMethod(int a, int b)
        {
            return a + b;
        }

        public int DeleteMethod(int a, int b)
        {
            return a - b;
        }
    }
}