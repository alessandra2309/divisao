
using System;


try
{
    Console.WriteLine("informe o primeiro valor: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("informe o primeiro valor: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = a / b;
   Console.WriteLine($"O resultado é{result}");
}catch(DivideByZeroException e)
{
   Console.WriteLine($"não é permitido divisão por zero! {e.Message}");
}catch(InvalidCastException e)
{

}catch(Exception e)
{

}
Console.ReadKey();
       
    
