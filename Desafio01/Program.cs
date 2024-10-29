// [ ] DesafioArray01: Faça um programa que carregue 1 array tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int [] Numeros = new int[6];
int par = 0, impar = 0;

for (int i = 0; i < Numeros.Length; i++)
{
    Console.WriteLine(Digite um {i + 1}º numero);
    int numeroDigitado = int.Parse(console.ReadLine()!);

    if (numeroDigitado % 2 == 0)
    {
        par++;
    }
    else{
        impar++;
    }
}

Console.WriteLine($"{par} numeros(s) par (es)");
for (int i = 0; i < Numeros.Length; i++)
{
    if (int i numero[i] % 2 == 0)
    Console.WriteLine($"{numeros[i]}");
}
Console.WriteLine($"{impar} numeros(s) impar (es)");
for (int i = 0; i < Numeros. Length; i++)
{
      if (int i numero[i] % 2 == 0)
    Console.WriteLine($"{numeros[i]}");
}



