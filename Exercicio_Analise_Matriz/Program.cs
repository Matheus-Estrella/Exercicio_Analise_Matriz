
// MATRIZES
const int size = 5;
float[,] matriz = new float[size, size];
int lin, col;
float[] soma_linhas = new float[size];
float[] soma_colunas = new float[size];
float diag_pri=0, diag_sec=0;
for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        matriz[lin, col] = new Random().Next(1, 10);
        soma_linhas[lin] += matriz[lin, col];
    }
}
for (col = 0; col < size; col++)
{
    for (lin = 0; lin < size; lin++)
    {
        soma_colunas[col] += matriz[lin, col];
        if(lin == col)
        {
            diag_pri += matriz[lin, col];
        }
        if(lin != col && lin+col == size)
        {
            diag_sec += matriz[lin, col];
        }
    }
}
Console.WriteLine("\nImprimindo Matriz: ");
for (lin = 0; lin < size; lin++)
{
    for (col = 0; col < size; col++)
    {
        Console.Write($"{matriz[lin, col]} "); ;
    }
    Console.WriteLine();
}
Console.WriteLine();
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
Console.Write("\nImprimindo Soma Linha: ");
for (lin = 0; lin < size; lin++)
{
    Console.Write($"{soma_linhas[lin]} ");
}
Console.WriteLine();
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
Console.Write("\nImprimindo Soma Colunas: ");
for (lin = 0; lin < size; lin++)
{
    Console.Write($"{soma_colunas[lin]} ");
}
Console.WriteLine();
<<<<<<< Updated upstream

Console.WriteLine($"\nImprimindo Soma da Diagonal Principal: {diag_pri}");
Console.WriteLine($"\nImprimindo Soma da Diagonal Secundária: {diag_sec} \n");
=======
Console.WriteLine($"\nImprimindo Soma da DIagonal Principal: {diag_pri} ");
Console.WriteLine($"\nImprimindo Soma da DIagonal Secundária: {diag_sec} \n");
>>>>>>> Stashed changes
