using System;

internal class Program
{
    static void Main(string[] args)
    {
        Central_911 llamada1 = Central_911.Obtener_Instancia();
        Central_911 llamada2 = Central_911.Obtener_Instancia();
        Central_911 llamada3 = Central_911.Obtener_Instancia();
        Central_911 llamada4 = Central_911.Obtener_Instancia();

        Operador op1 = new Operador(1, "Laura");
        Operador op2 = new Operador(2, "Carlos");
        Operador op3 = new Operador(3, "Miguel");
        Operador op4 = new Operador(4, "Ana Gastelum");
        Operador op5 = new Operador(5, "Pedro");
        Operador op6 = new Operador(6, "Moises");

        llamada1.ConectarLlamada(op1, "Incendio");
        llamada2.ConectarLlamada(op2, "Violeta");
        llamada3.ConectarLlamada(op3, "Accidente");
        llamada4.ConectarLlamada(op4, "Intento de suicidio");

        llamada1.ConectarLlamada(op5, "Robo");
        llamada2.ConectarLlamada(op6, "Emergencia medica");
        llamada3.ConectarLlamada(op2, "Violencia domestica");
        llamada4.ConectarLlamada(op1, "Accidente");

        Console.WriteLine("\nVerificando instancia única:");

        Console.WriteLine("llamada1 == llamada2: " + ReferenceEquals(llamada1, llamada2));
        Console.WriteLine("llamada1 == llamada3: " + ReferenceEquals(llamada1, llamada3));
        Console.WriteLine("llamada1 == llamada4: " + ReferenceEquals(llamada1, llamada4));

        Console.ReadKey();
    }
}