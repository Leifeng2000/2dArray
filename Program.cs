internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the size of the square matrix: ");
        int size = int.Parse(Console.ReadLine());

        double[,] matrix = new double[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Enter the value for element [{i}][{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double sum = 0;

        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine($"The sum of the numbers on the main diagonal is: {sum}");
    }
}