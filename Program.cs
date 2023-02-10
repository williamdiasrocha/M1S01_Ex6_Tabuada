// See https://aka.ms/new-console-template for more information

//Exercício 6 - TABOADA

Console.WriteLine("Qual tabuadoa você quer aprender?");
int tabuada = int.Parse(Console.ReadLine());

int num = 0;
Console.WriteLine("O Resultado desta Tabuada é: ");


for (int i = 0; i < 11; i++){
    int resultado = num * tabuada;
    Console.WriteLine(num + " x " + tabuada +" = " + resultado);
    num = num + 1;
}




