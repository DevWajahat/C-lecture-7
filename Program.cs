namespace c__lecture_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate.Multiply(4, 5);
        }
    }

    class Calculate
    {
        public static void add(int a , int b)
        {
            Console.WriteLine(a+b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine((a * b));
        }
    }
    class solve
    {
        public static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    public class Employee
    {
        public string _employeeName;
        public int _empAge;
        public string _deptName;
    }
}