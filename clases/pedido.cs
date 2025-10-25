public class Pedido
{
   public int Id { get; set; }

   //public DateTime Fecha { get; set; }// opcion 1
    public DateTime Fecha => DateTime.Now;

   public List<ItemPedido> Items { get; set; }

    public decimal Total => Items.Sum(Item => Item.SubTotal);

    public Pedido(int IdPedido)
    {
        Id = IdPedido;
        Items = new List<ItemPedido>();
        //Fecha = DateTime.Now;
    }

    public void AgregarItem(Producto Producto, int Cantidad)
    {
        if (Producto.Stock >= Cantidad)
        {
        //Agregar elemento a la lista 
        Items.Add(new ItemPedido(Producto, Cantidad));
        Producto.DisminuirStock(Cantidad);
           Console.WriteLine($"El Producto {Producto.Nombre} con cantidad {Cantidad}, se ha agregado al Pedido");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"No hay suficiente stock de {Producto.Nombre}");
        }
    }

    public void MosrarDetalles()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Detalles del pedido #{Id}");
        Console.WriteLine($"Fecha: {Fecha: hh/MM/yyyy hh:mm:ss tt}");

        foreach (var item in Items)
        {
            Console.WriteLine($"Producto: {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Subtotal: {item.SubTotal:C}");
        }
        Console.WriteLine($"Total: {Total:C}");
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }
}