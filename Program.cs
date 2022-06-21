Console.WriteLine("Welcome to line Comparison Program");
Console.WriteLine("Write Value for first line");
Console.WriteLine("Write First number");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write Second number");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write Third number");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write Fourth number");
int y2 = Convert.ToInt32(Console.ReadLine());
int z1 = x2 - x1;
int z2 = y2 - y1;
double num1 = Math.Pow(z1, 2);
double num2 = Math.Pow(z2, 2);
double distance = Math.Sqrt(num1 + num2);
Console.WriteLine("distance : " + distance);


Console.WriteLine("Write Value for first line");
Console.WriteLine("Write First number");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write Second number");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write Third number");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write Fourth number");
int b2 = Convert.ToInt32(Console.ReadLine());

int c1 = a2 - a1;
int c2 = b2 - b1;
double numb1 = Math.Pow(c1, 2);
double numb2 = Math.Pow(c2, 2);
double distance1 = Math.Sqrt(numb1 + numb2);

Console.WriteLine("distance1 : " + distance1);

if (distance == distance1)
{
    Console.WriteLine("equal");
}
else
{
    Console.WriteLine("not equal");
}