using System;

namespace lab._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Func<Action<int>, bool, char, string> lambda = (x, flag, y) =>
            {
                x(100);
                return (flag) ? "flag is true " + y : "flag is false " + y;
            };
            Action<int> TT = MyFunc;
            Console.WriteLine(lambda(TT, true, 'Y'));
            Console.WriteLine(lambda(TT, false, 'N'));
            Console.ReadLine();
        }
        static void MyFunc(int s)
        {
            s++;
            Console.WriteLine(s);
        }
    }
}
