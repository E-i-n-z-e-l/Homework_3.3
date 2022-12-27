int Cubing(int c_u_b_e)
{
    int count = 0;
    while (count <= c_u_b_e)
    {
        Console.WriteLine(c_u_b_e + " | " + Math.Pow(c_u_b_e, 3));
        count++;
    }
    return c_u_b_e;
}

Console.WriteLine("Введите число ");
int cube = Convert.ToInt32(Console.ReadLine());

int cuber = Cubing(cube);

Console.WriteLine(cuber);



//while (count <= cube)
//{
//    Console.WriteLine(count + " | " + Math.Pow(count, 3));
//    count++;
//}






