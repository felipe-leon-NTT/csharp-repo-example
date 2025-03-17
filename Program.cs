using System;
using Newtonsoft.Json;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var producto = new Producto { Id = 1, Nombre = "Producto 1", Precio = 10.0m };
            string json = JsonConvert.SerializeObject(producto);
            Console.WriteLine(json);
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}