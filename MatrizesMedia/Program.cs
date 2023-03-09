double[,] table = new double[5, 3];
Random rnd = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 2; j++)
    {
        int num = rnd.Next(100);
        table[i, j] = num;
    }
    table[i, 2] = (table[i, 1] + table[i, 0]) / 2;
    for (int k = 0;  k < 3; k++)
    {
    Console.Write(table[i, k] + " ");
    } 
    Console.WriteLine("\n");
}

