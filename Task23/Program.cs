void Cubing(int c_u_b_e)
{
    int count = 1;
    while (count <= c_u_b_e)
    {
        Console.WriteLine($"{count} "+Math.Pow(count, 3));
        count++;
    }
    
}

Console.WriteLine("Введите число ");
int cube = Convert.ToInt32(Console.ReadLine());

if (cube > 0)
{
    Cubing(cube);
}
else 
{
    Console.WriteLine($"Число {cube} не натуральное");
}







//while (count <= cube)
//{
//    Console.WriteLine(count + " | " + Math.Pow(count, 3));
//    count++;
//}






