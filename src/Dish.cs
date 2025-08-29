namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish 
    {
        public string Name {get; set;} // Es otra forma de poner los get y set. La funcion es la misma.
        
        public float Price { get; set; }
        
        public bool IsVegetarian { get; set; } //Si devuelve true es vegano. Sino no es vegano.

        public Dish(string name, float price, bool isVegetarian) // Constructor
        {
            Name = name; // Le asigno al atributo el valor que me pasan. Aca a la propiedad con mayuscula Name(de la clase), se le asigna el nombre que se le ponen al crear la instancia, ejemplo: "Milanesa Napolitana"
            Price = price;
            IsVegetarian = isVegetarian;
        }
        
        
      
       
    }
}