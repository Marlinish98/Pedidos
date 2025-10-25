public class ItemPedido
{
    public Producto Producto { get; set; }
    
    public int Cantidad { get; set; }

    public decimal SubTotal => Producto.Precio * Cantidad;

    public ItemPedido(Producto Producto, int Cantidad)
    {
        this.Producto = Producto;// los this es porque se usan los mismos nombres de variable
        this.Cantidad = Cantidad;
    }

}