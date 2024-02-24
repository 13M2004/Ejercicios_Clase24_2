Console.WriteLine("Ejercicico #3");
int eenum = 0;
int eeresul = 0;

do
{ 
    Console.WriteLine("Ingrese un numero positivo e ingrese un umero negativo si quiere salir del bucle:");
    eeresul = eenum + eeresul;
    eenum = int.Parse(Console.ReadLine());
   
} while (eenum > 0);
Console.WriteLine("La suma de los numeros ingresados es:" + eeresul);
Console.ReadLine();