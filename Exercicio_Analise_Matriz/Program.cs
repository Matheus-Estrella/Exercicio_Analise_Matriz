
// MATRIZES
const int size = 10;
int lin, col;

float[,] Gerar_Matriz_Quadrada(int size)
{
    float[,] matriz = new float[size, size];
    for (lin = 0; lin < size; lin++)
    {
        for (col = 0; col < size; col++)
        {
            matriz[lin, col] = new Random().Next(1, 10);
        }
    }
    return matriz;
}
float[] Somar_Linhas(float[,] matriz, int size)
{
    float[] vet = new float[size];
    for (lin = 0; lin < size; lin++)
    {
        for (col = 0; col < size; col++)
        {
            vet[lin] += matriz[lin, col];
        }
    }
    return vet;
}
float[] Somar_Colunas(float[,] matriz, int size)
{
    float[] vet = new float[size];
    for (col = 0; col < size; col++)
    {
        for (lin = 0; lin < size; lin++)
        {
            vet[col] += matriz[lin, col];
        }
    }
    return vet;
}
float Somar_Diagonal_Principal(float[,] matriz, int size)
{
    float diag_pri = 0;
    for (col = 0; col < size; col++)
    {
        for (lin = 0; lin < size; lin++)
        {
            if (lin == col)
            {
                diag_pri += matriz[lin, col];
            }
        }
    }
    return diag_pri;
}
float Somar_Diagonal_Secundaria(float[,] matriz, int size)
{
    float diag_sec = 0;
    for (col = 0; col < size; col++)
    {
        for (lin = 0; lin < size; lin++)
        {
            if (lin != col && lin + col == size)
            {
                diag_sec += matriz[lin, col];
            }
        }
    }
    return diag_sec;
}
void Imprimir_Matriz(float[,] matriz)
{
    Console.WriteLine("\nImprimindo Matriz: ");
    for (int lin = 0; lin < size; lin++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write($"{matriz[lin, col]} "); ;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Imprimir_Vetor(float[] vet)
{
    for (int lin = 0; lin < size; lin++)
    {
        Console.Write($"{vet[lin]} ");
    }
    Console.WriteLine();

}
void Run()
{
    float[,] matriz = new float[size, size];
    float[] soma_linhas = new float[size];
    float[] soma_colunas = new float[size];
    float diag_pri = 0, diag_sec = 0;

    matriz = Gerar_Matriz_Quadrada(size);
    Imprimir_Matriz(matriz);

    Console.Write("\nImprimindo Soma Linha: ");
    Imprimir_Vetor(Somar_Linhas(matriz, size));

    Console.Write("\nImprimindo Soma Colunas: ");
    Imprimir_Vetor(Somar_Colunas(matriz, size));

    Console.WriteLine($"\nImprimindo Soma da Diagonal Principal: {Somar_Diagonal_Principal(matriz, size)} ");
    Console.WriteLine($"\nImprimindo Soma da Diagonal Secundária: {Somar_Diagonal_Secundaria(matriz, size)} \n");

}

Run();