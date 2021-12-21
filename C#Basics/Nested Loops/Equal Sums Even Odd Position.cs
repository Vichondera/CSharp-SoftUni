namespace EqualSums
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            for (int i = N1; i <= N2; i++)
            {
                string num = i.ToString();

                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < num.Length; j++)
                {
                    char magic = num[j];
                    int digit = int.Parse(magic.ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
            
        }
    }
}
