// // Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
double AB (int X1, int Y1, int Z1, int X2 , int Y2, int Z2)

{
int A = Convert.ToInt32(Math.Pow(X2-X1, 2));
int B = Convert.ToInt32(Math.Pow(Y2-Y1, 2));
int C = Convert.ToInt32(Math.Pow(Z2-Z1, 2));
double D = Convert.ToDouble(Math.Sqrt(A+B+C));

return Math.Round(D,2);
}



Console.WriteLine($"Расстояние между точками {AB (7,-5,0,1,-1,9)}");



// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2