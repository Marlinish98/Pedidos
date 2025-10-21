public class Producto {

public int Id{ get; set; }
public string? Nombre {get; set;} 
public decimal Precio {get; set;}
public int Stock {get; set;}


public void MostrarInformacion(){
    Console.WriteLine("***** DATOS DEL PRODUCTO *****");
    //Console.WriteLine("ID: "+ Producto.Id + "."); opcion 1
    Console.WriteLine($"ID: {Id}"); // opcion 2
    Console.WriteLine($"Nombre: {Nombre}");
    Console.WriteLine($"Precio: {Precio}");
    Console.WriteLine($"Cantidad Disponible: {Stock}");
    Console.WriteLine("");
    // Console debera ir iniciada con Mayuscula

}// fin mostrar info


public void DisminuirStock(int Cantidad){
if(Stock >= Cantidad){
    Stock -= Cantidad;    
}
else
{
    Console.WriteLine($"No hay suficiente Stock de {Nombre}");
    Console.WriteLine("");
}
}

}