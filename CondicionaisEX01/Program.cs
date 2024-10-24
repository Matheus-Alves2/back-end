Console.WriteLine($"pode me informar o seu salario");
float Salario = float.Parse(Console.ReadLine());

Console.WriteLine($"pode me informar quanto voce gasta por mes");
float Gastos = float.Parse(Console.ReadLine());


if(Salario >= Gastos)
{
    Console.WriteLine($"Gastos dentro do orcamento");
    
}
else
{
    Console.WriteLine($"Orcamento estourado");
    
}

