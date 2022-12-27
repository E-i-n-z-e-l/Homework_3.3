double distance3D3D3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distanceStart = (Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    double distanceEnd = Math.Sqrt(distanceStart);
    return distanceEnd;
}

Console.WriteLine("Введите координату X1 ");
int coordinateX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1 ");
int coordinateY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1 ");
int coordinateZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2 ");
int coordinateX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2 ");
int coordinateY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2 ");
int coordinateZ2 = Convert.ToInt32(Console.ReadLine());

double spacing = distance3D3D3D(coordinateX1, coordinateY1, coordinateZ1, coordinateX2, coordinateY2, coordinateZ2);

Console.WriteLine(spacing);
