string[] frutas = { "melancia", "jabuticaba", "melao", "abacate", "carambola", "kiwi", "pera", "morango", "pitaya", "banana", "acerola," "limao", "acerola","pinha", };

Console.Write($"Sua sacola contem {frutas.Length} frutas");

foreach (string f in frutas)
{
    Console.WriteLine($"{f},");
}

Console.WriteLine();
