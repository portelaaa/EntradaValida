Console.WriteLine("Entrada Válida");

int numeroum = -1;

while (numeroum < 0 || numeroum > 9)
{
    Console.WriteLine("Digite um número entre 1 e 9 (ou 0 para cancelar)...");
    Int32.TryParse(Console.ReadLine(), out numeroum);
}


if (numeroum == 0)
{
    Console.WriteLine("Operação cancelada.");

}
else
{
    Console.WriteLine ($"Número selecionado = {numeroum}");
}

Console.WriteLine("Obrigado, volte sempre!");
