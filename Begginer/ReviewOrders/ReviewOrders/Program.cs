using System;

namespace ReviewOrders
{
    class Program
    {
        /*El equipo ha encontrado un patrón.Los pedidos que comienzan por la letra "B" presentan un 
        fraude con una frecuencia 25 veces superior a la normal.Deberá escribir otro código que genere 
        el identificador de pedido para los nuevos pedidos que empiecen por la letra "B". El equipo 
        antifraude lo usará para investigar más en profundidad.*/
        static void Main(string[] args)
        {
            string[] orderns = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

            foreach (var item in orderns)
            {
                string wordUpper = item.ToUpper();

                if (wordUpper.StartsWith('B'))
                {
                    Console.WriteLine($"El pedido {item} es potencialmente fraudulento que que empieza por la letra 'B'");
                }
            }
        }
    }
}
