// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double SearchX(double K1, double B1, double K2, double B2)
{
    double x = (B2 - B1) / (K1 - K2);
    return x;
}


double SearchY(double B1, double K1, double x)
{
    double y = K1 * x + B1;
    return y;
}


Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
Double b2 = Convert.ToDouble(Console.ReadLine());


double x = SearchX(k1, b1, k2, b2);
double y = SearchY(k1, b1, x);



x = Math.Round(x, 1);
y = Math.Round(y, 1);

if (k1 == k2)
{
    Console.WriteLine("прямые парралельны");
}
else
{

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}
