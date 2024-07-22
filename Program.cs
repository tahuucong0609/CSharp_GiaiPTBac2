using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Chương trình giải phương trình bậc hai");
        double a, b, c;
        Console.Write("Nhap a: "); a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap b: "); b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap c :"); c = Convert.ToDouble(Console.ReadLine());
        Gptb2(a, b, c);
    }
    private static void Gptb2(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0) Console.WriteLine("Phương có vô số nghiệm");
                else if (c != 0) Console.WriteLine("Phương trình vô nghiệm");
            }
            else Console.WriteLine($"Phương trình có một nghiệm {-b / a}");
        }
        else if (delta < 0) Console.WriteLine("Phương trình vô nghiệm");
        else if (delta == 0) Console.WriteLine($"Phương trình nghiệm kép {-b / 2 * a}");
        else if (delta > 0) Console.WriteLine($"Phương trình có hai nghiệm \nx1 = {(-b - Math.Sqrt(delta)) / 2 * a}\n x2 = {(-b + Math.Sqrt(delta)) / 2 * a} ");
    }
}
