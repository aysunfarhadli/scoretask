using System;

class Program
{
    static string QiymetHesabla(int bal)
    {
        if (bal >= 91 && bal <= 100)
            return "A";
        else if (bal >= 81 && bal <= 90)
            return "B";
        else if (bal >= 71 && bal <= 80)
            return "C";
        else if (bal >= 61 && bal <= 70)
            return "D";
        else if (bal >= 51 && bal <= 60)
            return "E";
        else
            return "F"; // 50 və aşağı üçün
    }

    static void Main()
    {
        try
        {
            Console.Write("Balı daxil edin: ");
            int bal = int.Parse(Console.ReadLine());

            if (bal >= 0 && bal <= 100)
            {
                Console.WriteLine("Qiymət: " + QiymetHesabla(bal));
            }
            else
            {
                Console.WriteLine("Bal 0 ilə 100 arasında olmalıdır.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Düzgün bir rəqəm daxil edin.");
        }
    }
}