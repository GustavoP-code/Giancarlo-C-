// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Bem vindo!");
string nomeAluno = "Gustavo Pereira da Silva";
int periodo = 2;
float nota1Bim = 8.9f;
float nota2Bim = 7.1f;
float somaNotas = nota1Bim + nota2Bim;
float media = somaNotas / 2;


Console.WriteLine("Período:" + periodo);
Console.WriteLine("Nome:" + nomeAluno);
Console.WriteLine("nota primeiro Bimestre:" + nota1Bim);
Console.WriteLine("Nota segundo Bimestre:" + nota2Bim);
Console.WriteLine("resultado da soma:" + somaNotas);
Console.WriteLine("Média do semestre:" + media); */


Console.Write("Digite o primeiro valor:");
Console.Write("Digite o segundo valor:");

int valor1 = 0;
int valor2 = 0;

string texto1 = Console.ReadLine();
valor1 = int.Parse(texto1);

string texto2 = Console.ReadLine();
valor2 = int.Parse(texto2);


int resultadoSoma = valor1 + valor2;   
int resultadoSubtração = valor1 - valor2;
int resultadoMultiplicação = valor1 * valor2;
float resultadoDivisão = valor1 / valor2;
float restoDivisão = valor1 % valor2;

Console.WriteLine($"A soma entre {valor1} e {valor1} é igual a: {resultadoSoma}");
Console.WriteLine(String.Concat("A subtração entre", valor1 , "e" , valor2 , "é igual a:", resultadoSubtração));
Console.WriteLine(String.Format("A multiplicação é:" + resultadoMultiplicação));
Console.WriteLine("A a divisão é:" + resultadoDivisão);
Console.WriteLine("O resto da divisão é:" + restoDivisão);

Console.ReadKey();