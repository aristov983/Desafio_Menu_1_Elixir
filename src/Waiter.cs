using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        
        private string Name { get; set; }
        private List<Table> assignedTables = new List<Table>();
        
        
        public void AssignTable(Table table)
        {
            assignedTables.Add(table); // Aca le asigno.
            Console.WriteLine("Se asigno una mesa al mozo✅");
        }

        public void TakeOrder(Table table, Dish dish)
        {
            if (table != null && dish != null)
            {
                table.Order.Add(dish); //aca agrego a la tabla y a la orden. accedo usando los puntos. table -> table.Order
                Console.WriteLine($"Se agregó '{dish.Name}' a la mesa {table.Number}."); // aca uso interpolacion en C#
            }
            else
            {
                Console.WriteLine("Error: la mesa o el platillo no existen❌.");
            }
        }
    }
}