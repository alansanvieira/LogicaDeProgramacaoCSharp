// See https://aka.ms/new-console-template for more information

//exemplo 1

float x = 4.5f;

double y = x;

Console.WriteLine(y);

//exemplo 2

double ax;
int bx;

ax = 5.1;
bx = (int)ax;

Console.WriteLine(bx);



//exemplo 3

int ad = 5;
int bd = 2;

double resultado = (double) ad / bd;

Console.WriteLine(resultado);



// Operadores Aritimeticos

int n1 = 3 + 4 * 2;
int n2 = (3 + 4) * 2;
int n3 = 17 % 3;
double n4 = (double)10 / 8;

double a = 1.0, b = -3.0, c = -4.0;
double delta = Math.Pow(b,2.0) - 4.0 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);




Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(delta);
Console.WriteLine(x1);
Console.WriteLine(x2);


