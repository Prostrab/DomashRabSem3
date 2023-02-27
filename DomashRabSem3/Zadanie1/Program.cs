// //  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// Console.WriteLine("Введите пятизначное число ");
// int A = Convert.ToInt32(Console.ReadLine());


// int B = (A/10000); // 1
// int C = (A/1000%10*10);//2
// int D = (A/100%110%10*100); //4
// int E = (A%1100%100/10*1000);
// int F = (A%1100%100%10*10000);
// int W = C+B+D+E+F; 

// if (W )
//  Console.WriteLine( $"Палиндром числа = {W}");


Console.WriteLine("Введите пятизначное число");
string X = Console.ReadLine();

if ( X[0] == X[4] && X[1] == X[3] )


{

Console.WriteLine(" => Yes");
}

else 
{

    Console.Write(" => No");
}