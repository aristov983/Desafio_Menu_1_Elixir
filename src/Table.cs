using System.Collections.Generic;
using System.Data;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        public bool IsOccupied {get;set;}
        public int Number{get;set;}

        public Table(int number, bool isOccupied)
        {
            Number = number;
            IsOccupied = isOccupied;
        }
        
      

        public List<Dish> Order
        {
            get
            {
                return order;
            }
        }

        public void Occupy() //Marca la mesa como ocupada
        {
            IsOccupied = true;
        }

        public void Free() //Marca la mesa como libre y vacía la lista de pedidos
        {
            IsOccupied = false;
            order.Clear();
        }

        public void AddToOrder(Dish plate) //agrega el plato plate a la lista order
        {
            order.Add(plate);
        }
        
        public bool HasOrders() //Devuelve true si hay alguna orden en la mesa
        {
            return this.order.Count > 0;
        }
    }
}