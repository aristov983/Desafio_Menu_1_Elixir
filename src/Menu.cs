using System;
using System.Collections.Generic;
using System.Xml;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        public List<Dish> dishes = new List<Dish>();

        public class Dish
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Dish(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Name} - ${Price}";
            }
        }

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        public void DellDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        public Dish GetDishByName(string name)
        {
            foreach (Dish d in dishes)
            {
                if (d.Name == name)
                {
                    return d;
                }
            }
            return null;
        }
    }
}