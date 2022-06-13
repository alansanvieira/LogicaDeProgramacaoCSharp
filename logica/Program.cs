// Significado das Coisas

sbyte x = 100;
Console.WriteLine(x);

byte n1 = 126;
Console.WriteLine(n1);

string nome = "Alan";
Console.WriteLine(nome);

int n2 = 54444;
Console.WriteLine(n2);

string carros = "City";
Console.WriteLine(carros);

Console.WriteLine(carros + " " + nome);

bool completo = false;
Console.WriteLine(completo);

char genero = 'F';
Console.WriteLine(genero);

float n5 = 4.5f;
double n6 = 4.6;

Console.WriteLine(n5);
Console.WriteLine(n6);

// execicios

Console.WriteLine("bom dia");
Console.WriteLine("Boa tarde");
Console.WriteLine("Boa noite");

char genero2 = 'F';
int idade = 32;
double saldo = 10.350;
string nome6 = "Alan";

Console.WriteLine("----------------------");
Console.WriteLine(genero2);
Console.WriteLine(idade);
Console.WriteLine(saldo.ToString("F4"));
Console.WriteLine(nome6);
Console.WriteLine(saldo.ToString("F1"));

// Contatenação

int idade7 = 32;
double saldo4 = 10.350;
string nome5 = "Alan";

Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome5, idade7, saldo4);

Console.WriteLine($"{nome5} tem {idade7} anos e tem saldo igual a reais {saldo4}");

Console.WriteLine(nome5 + " tem " + idade7 + " anos e tem saldo a " + saldo4 + "reais");

//Exercicío de Fixação

Console.WriteLine("-------------------------------------------------");
string produto1 = "Computador";
string produto2 = "Mesa de escritório";
byte idade9 = 30;
int codigo = 5290;
char genero0 = 'M';
double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;
Console.WriteLine("Produtos:");
Console.WriteLine(produto1 + " ,cujo o preço é $ 2100,0");
Console.WriteLine(produto2 + " ,cujo o preço é $ 650,50");
Console.WriteLine("Registro: " + idade9 + " anos de idade," + " código" + codigo + " e gênero " + genero0);
Console.WriteLine(medida.ToString("F8"));
Console.WriteLine(medida.ToString("F3"));


//Operadores de Atribuição

Console.WriteLine("----------------------------------------------");
int a = 10;
Console.WriteLine(a);

a += 2;
Console.WriteLine(a);

a *= 3;
Console.WriteLine(a);

string s = "ABC";
Console.WriteLine(s);

s += "DEF";
Console.WriteLine(s);

int q = 10;
int e = ++q;


Console.WriteLine(q);
Console.WriteLine(e);


