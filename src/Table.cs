using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        private int number;
        private bool isoccupied = false;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
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
            isoccupied = true;
        }

        public void Free() //Marca la mesa como libre
        {
            isoccupied = false;
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