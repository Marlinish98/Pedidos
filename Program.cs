// creamos el objeto tipo producto
Producto Producto = new Producto();
Producto Producto1 = new Producto();

Producto.Id = 1;
Producto.Nombre ="Laptop";
Producto.Precio = 13500;
Producto.Stock = 10;
Producto.MostrarInformacion();
//Producto.DisminuirStock(10);
//Producto.MostrarInformacion();

Producto1.Id = 2;
Producto1.Nombre ="Mouse";
Producto1.Precio = 250;
Producto1.Stock = 100;
Producto1.MostrarInformacion();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(Producto, 150);
pedido.AgregarItem(Producto1, 45);
pedido.MosrarDetalles();

Console.WriteLine("********** Actualización de Productos **********");
Producto.MostrarInformacion();
Producto1.MostrarInformacion();

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "Iphone 17 pro Max";
electronico.Precio = 52000;
electronico.Stock = 10;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110v";
electronico.MostrarInformacion();

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El principito";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "73647383646";
libro.Autor = "Antoine de Saint Exupery";
libro.NumeroPaginas = 170;
libro.MostrarInformacion();