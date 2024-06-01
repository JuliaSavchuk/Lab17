namespace Lab17
{
    internal class Program
    {
        public delegate bool Num_Delegate(int num);
        public delegate int Operation_Delegate(int num);
        public delegate bool Day_Delegate(int day);
        public delegate int Array_Delegate(int[] array);
        public delegate int[] Odd_Delegate(int[] array);
        static void Main(string[] args)
        {
            Console.WriteLine("-----Task 1-----\n");
            Num_Delegate numEven = (num) =>
            {
                return num % 2 == 0;
            };
            Console.WriteLine($"Num Even -> {numEven(9)}");
            Console.WriteLine($"Num Even -> {numEven(20)}");

            Console.WriteLine("\n\n-----Task 2-----\n");
            Operation_Delegate Square = (num) =>
            {
                return num * num;
            };
            Console.WriteLine($"Square 7 -> {Square(7)}");
            Console.WriteLine($"Square 3 -> {Square(3)}");

            Console.WriteLine("\n\n-----Task 3-----\n");
            Operation_Delegate cube = (number) =>
            {
                return number * number * number;
            };
            Console.WriteLine($"Cube 6 -> {cube(6)}");
            Console.WriteLine($"Cube 2 -> {cube(2)}");

            Console.WriteLine("\n\n-----Task 4-----\n");
            Day_Delegate programDay = (day) => day == 256;
            Console.WriteLine($"Is day 256 the Programmer's Day? {programDay(256)}");
            Console.WriteLine($"Is day 200 the Programmer's Day? {programDay(115)}");

            Console.WriteLine("\n\n-----Task 5-----\n");
            Array_Delegate maxInArray = (array) => array.Max();
            int[] numbers = { 19, 2, 11, 17, 3, 4, 1, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"Max in array -> {maxInArray(numbers)}");

            Console.WriteLine("\n\n-----Task 6-----\n");
            Array_Delegate minInArray = (array) => array.Min();
            Console.WriteLine($"Min in array -> {minInArray(numbers)}");

            Console.WriteLine("\n\n-----Task 7-----\n");
            Odd_Delegate oddNumbers = (array) => array.Where(number => number % 2 != 0).ToArray();
            int[] oddNumbersResult = oddNumbers(numbers);
            Console.WriteLine($"Odd numbers in array -> " +
                $"{string.Join(", ", oddNumbersResult)}");
        }
    }

    //public delegate void MyDelegate();
    //public delegate string Delegate_1(string str);

    //static void Main(string[] args)
    //{
    //    var a = new A();
    //    MyDelegate del = a.Show;
    //    del();
    //    Delegate_1 de_1 = /*delegate */(/*string*/ str) =>
    //    {
    //    Console.WriteLine(str);
    //        return str;
    //    };
    //    de_1("Hello");
    //    Delegate_1 de_2 = (str) =>
    //    {
    //    Console.WriteLine(str);
    //        return "Hello";

    //    };
    //    de_2("World!");
    //    MyDelegate de_3 = () =>
    //    {
    //    Console.WriteLine("str");
    //    };
    //    de_3();
    //}


    //public class A
    //{
    //    public void Show() =>
    //        Console.WriteLine("Text");
    //}
}