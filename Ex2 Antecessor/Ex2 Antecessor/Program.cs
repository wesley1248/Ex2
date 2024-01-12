Console.Write("Quantos numeros vai digitar?: ");
int quantidade = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantidade; i++)
{

    Console.Write($"Digite o {i} numero: ");
    int numeroInicial = int.Parse(Console.ReadLine());

    int numero = numeroInicial - 1;

    Console.WriteLine($"O antecessor de {numeroInicial} é: {numero}");
}

Console.ReadKey();
