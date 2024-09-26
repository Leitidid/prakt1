
namespace WpfLibrary1
{
    public class Class1
    {
        public static void rnd(int k)
        {
            Random rnd = new Random();
            int sum = 0;
            int count = 0;
            while (sum <= k)
            {
                int num = rnd.Next(-7, 4);
                sum += num;
                count++;
                Console.WriteLine("сгенерированные числа" + num);
                Console.WriteLine("сумма сгенерированных чисел" + sum);
            }
            Console.WriteLine("количество сгенерированных чисел" + count);
        }
    }

}
