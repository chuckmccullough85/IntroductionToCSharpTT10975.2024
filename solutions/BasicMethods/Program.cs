
var ftemps = new double[] { -40, 0, 20, 32, 65, 72, 100, 150, 212 };
foreach (var f in ftemps)
{
    var c = F2C(f);
    var k = F2K(f);
    Console.WriteLine($"{f}F is {c}C and {k}K");

    Console.WriteLine($"Convert back: {C2F(c)}f, {K2F(k)}f");
}


double F2C (double fahr)
{
    double C = 5.0f / 9.0f * (fahr - 32);
    return C;
}
double F2K (double fahr)
{
    return C2K(F2C(fahr));
}
double C2F (double cels)
{
    return cels * 9 / 5 + 32;
}
double C2K(double cels)
{
    return cels + 274.15;
}
double K2C(double k)
{
    return k - 274.15;
}
double K2F(double k)
{
    return C2F(K2C(k));
}