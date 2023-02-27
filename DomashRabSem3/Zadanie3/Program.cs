// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Kub (int value)
{
    for (int i = 1; i <= value; i++)

        { 
            Console.Write($"{Math.Pow(i,3)}");
            Console.Write(i==value? "." : ",");
        

        }
Console.WriteLine(" ");


}

Kub (6);