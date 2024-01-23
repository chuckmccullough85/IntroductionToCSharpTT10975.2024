/*
 * 1 C is 274.15 K
 * F = C X 9/5 + 32
 * C = 5/9(F-32)
 */

Console.WriteLine(5 / 9); Console.WriteLine(9 / 5);

double F = 72;
double C = 5.0f / 9.0f * (F - 32);
double K = C + 274.15;

Console.WriteLine($"{F}f is {C}c which is {K}k");

C = 40;
F = C * 9 / 5 + 32;
K = C + 274.15;
Console.WriteLine($"{F}f is {C}c which is {K}k");