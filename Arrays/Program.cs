 

string[] carros = new string[3];

Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
carro[0] = Console.ReadLine()!;

for (int i = 0; i < carros.Length; i++)
{
    Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
    carro[i] = Console.ReadLine()!;

}

Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
carro[2] = Console.ReadLine()!;

Console.WriteLine($"carro cadastrado é {carros[0]}, {carros[1]}, {carros[2]}");





