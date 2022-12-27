int Palindrome(int number)
{
    if (number < 100000 && number > 9999)
    {
        if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Введенное число не пятизначное");
    }
    return number;
}

Console.WriteLine("Введите пятизначное число ");
int number55555 = Convert.ToInt32(Console.ReadLine());

int numberPalindrome = Palindrome(number55555);

