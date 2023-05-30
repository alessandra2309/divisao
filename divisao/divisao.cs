public class progam
{
    static void Main(string[] args)
    {
        Console.WriteLine("informe o primeiro valor: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("informe o primeiro valor: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int result = a / b;
        Console.WriteLine(result);
    }
}