public class Producto {

public int Id{ get; set; }
public string? Nombre {get; set;} 
public decimal Precio {get; set;}
public int Stock {get; set;}

/// <summary>
/// Muestra la Informacion de todos los datos ingresados
/// </summary>
public virtual void MostrarInformacion(){
    Console.WriteLine("***** DATOS DEL PRODUCTO *****");
    //Console.WriteLine("ID: "+ Producto.Id + "."); opcion 1
    Console.WriteLine($"ID: {Id}"); // opcion 2
    Console.WriteLine($"Nombre: {Nombre}");
    Console.WriteLine($"Precio: {Precio:C}");
    Console.WriteLine($"Cantidad Disponible: {Stock}");
    
    // Console debera ir iniciada con Mayuscula

}// fin mostrar info

/// <summary>
/// Funcion para la resta del Stock del producto
/// </summary>
/// <param name="Cantidad"></param>
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