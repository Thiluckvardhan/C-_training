namespace Day17
{
    public class ThreadExample
    {
        public void Example1()
        {
            Thread t1 = new Thread(Task1);
            Thread t2 = new Thread(Task2);
            t1.Start();
            t2.Start();
        }

        private void Task1()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.Write($"{i} ");
                Thread.Sleep(100);
            }
        }

        private void Task2()
        {
            for(int i = 1; i <= 100; i += 2)
            {
                Console.Write($"{i} ");
                Thread.Sleep(100);
            }
        }
    }
}