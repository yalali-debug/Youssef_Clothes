int opcion = -1;
int numeroOperacion = 0;
double recaudacionTotal = 0;
double ventaMasCara = 0;
string clienteVentaMasCara = "";
while(opcion != 0)

{   
    Console.WriteLine("----------------------");
    Console.WriteLine("----------------------");
    Console.WriteLine("  YOUSSEF CLOTHES ");
    Console.WriteLine("----------------------");
    Console.WriteLine("----------------------");
    Console.WriteLine("1. Registrar Compra");
    Console.WriteLine("2. Consultar balance de tienda");
    Console.WriteLine("0. Cerrar tienda");
    Console.Write("Seleciona una opcion: ");

    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("Opcion introducida: " + opcion);

    switch (opcion)
    {
        case 1:
            {
                // DATOS DEL CLIENTE
                string nombreCliente = "";

                do
                {
                    Console.Write("Introduce nombre del cliente: ");
                    nombreCliente = Console.ReadLine();

                    if (nombreCliente.Trim() == "")
                    {
                        Console.WriteLine("El nombre no puede estar vacio");
                    }
                }while (nombreCliente.Trim() == "");

                Console.WriteLine("Cliente registrado: " + nombreCliente);
                int producto;
                double precio = 0;
                string nombreProducto = "";
                int talla = 0;
                string tallaEscogida = "";
                int opcionExtra = -1;
                int opcionRegalo = 0;
                double precioRegalo = 0;
                string tipoCompra = "";

                

                do
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("----------------------");
                    Console.WriteLine(" PRODUCTOS EN VENTA ");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1. Camisetas");
                    Console.WriteLine("2. Abrigos");
                    Console.WriteLine("3. Pantalones");
                    Console.WriteLine("4. Sudaderas");
                    Console.WriteLine("5. Zapatillas");
                    Console.Write("Seleciona un producto: ");

                    producto = int.Parse(Console.ReadLine());
                } while (producto < 1 || producto > 5);
                switch (producto)
                {
                    case 1:
                        nombreProducto = "Camisetas";
                        break;
                    case 2: 
                        nombreProducto = "Abrigos";
                        break;
                    case 3:
                        nombreProducto = "Pantalones";
                        break;
                    case 4:
                        nombreProducto = "Sudaderas";
                        break;
                    case 5:
                        nombreProducto = "Zapatillas";
                        break;
                }
                Console.WriteLine("Producto comprado: " + nombreProducto);
                
                switch (producto)
                {
                    case 1:
                    case 2:
                    case 4:
                        Console.WriteLine("........................");
                        Console.WriteLine("........................");
                        Console.WriteLine(" TALLAS DISPONIBLES ");
                        Console.WriteLine("........................");
                        Console.WriteLine("........................");
                        Console.WriteLine("1. S / M");
                        Console.WriteLine("2. L / XL");
                        break;
                    case 3:
                        Console.WriteLine("........................");
                        Console.WriteLine("........................");
                        Console.WriteLine(" TALLAS DISPONIBLES ");
                        Console.WriteLine("........................");
                        Console.WriteLine("........................");
                        Console.WriteLine("1. 35 - 39");
                        Console.WriteLine("2. 40 - 44");
                        break;
                    case 5:   
                        Console.WriteLine("........................");
                        Console.WriteLine("........................");
                        Console.WriteLine(" TALLAS DISPONIBLES ");
                        Console.WriteLine("........................");
                        Console.WriteLine("........................");
                        Console.WriteLine("1. 35 - 40");
                        Console.WriteLine("2. 41 - 44");
                        break;
                }
                do
                {
                    Console.WriteLine("Seleciona una talla");
                    talla = int.Parse(Console.ReadLine());
                }while (talla < 1 || talla > 2);
                switch (producto)
                {
                    case 1: 
                        if (talla == 1)
                        {
                            precio = 15;
                        }
                        else
                        
                        {
                            precio = 25;
                        }
                        break;
                    case 2:
                        if (talla == 1)
                        {
                            precio = 100;
                        }
                        else
                        {
                            precio = 120;
                        }
                        break;
                    case 3:
                        if (talla == 1)
                        {
                            precio = 25;
                        }
                        else
                        
                        {
                            precio = 30;
                        }
                        break;
                    case 4:
                        if(talla == 1)
                        {
                            precio = 25;
                        }
                        else
                        {
                            precio = 35;
                        }
                        break;
                    case 5:
                        if(talla == 1)
                        {
                            precio = 100;
                        }
                        else
                        
                        {
                            precio = 120;
                        }
                        break;
                    
                        
                }
                switch (producto)
                {
                    case 1:
                    case 2:
                    case 4:
                        if (talla == 1)
                        {
                            tallaEscogida = "S / M";
                        }
                        else
                        {
                            tallaEscogida = "L / XL";
                        }
                        break;
                    case 3:
                        if (talla == 1)
                        {
                            tallaEscogida = "35 - 39";
                        }
                        else
                        {
                            tallaEscogida = "40 - 44";

                        }
                        break;
                    case 5: 
                        if (talla == 1)
                        {
                            tallaEscogida = "35 - 40";
                        }
                        else
                        {
                            tallaEscogida = "41 - 44";
                        }
                        break;
                }
                Console.WriteLine("Talla escogida: " + tallaEscogida);
                Console.WriteLine("---- RESUMEN DE TU COMPRA ----");
                Console.WriteLine("Cliente: " + nombreCliente);
                Console.WriteLine("Producto: " + nombreProducto);
                Console.WriteLine("Talla: " + tallaEscogida);
                Console.WriteLine("Precio: " + precio + " €");

                bool bolsaElegida = false;
                bool calcetinesElegidos = false;
                bool personalizacionElegida = false;

                double totalExtras = 0;
                int cantidadExtras = 0;

                // MENU PRINCIPAL DE LA TIENDA
                while(opcionExtra != 0)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("----------------------");
                    Console.WriteLine(" EXTRA DISPONIBLE");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("1. Bolsa de regalo - 3€");
                    Console.WriteLine("2. Pack de calcetines - 5€");
                    Console.WriteLine("3. Personalizacion de prendas - 8€");
                    Console.WriteLine("0. Terminar seleccion de extras");

                    Console.Write("Seleciona una extra:");
                    opcionExtra = int.Parse(Console.ReadLine());

                    switch (opcionExtra)
                    {
                        case 1:
                            if (bolsaElegida == false)
                            {
                                bolsaElegida = true;
                                totalExtras = totalExtras + 3;
                                cantidadExtras++;
                                Console.WriteLine("Bolsa de regalo añadido");
                                
                            }
                            else
                            {
                                Console.WriteLine("Ya has elegido este extra");
                            }
                            break;
                        case 2 :
                            if (calcetinesElegidos == false)
                            {
                                calcetinesElegidos = true;
                                totalExtras = totalExtras + 5;
                                cantidadExtras++;
                                Console.WriteLine("Pack de calcetines añadido");
                            }
                            else
                            {
                                Console.WriteLine("Ya has elegido este extra");
                            }
                            break;
                        case 3 : 
                            if (personalizacionElegida == false)
                            {
                                personalizacionElegida = true;
                                totalExtras = totalExtras + 8;
                                cantidadExtras++;
                                Console.WriteLine("Personalizacion añadida");
                            }
                            else
                            {
                                Console.WriteLine("Ya has elegido este extra");
                            }
                            break;
                        case 0 : 
                            Console.WriteLine("Has terminado de seleccionar extras");
                            break;
                        default : 
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                    Console.WriteLine("Cantidad de extras: " + cantidadExtras);
                    Console.WriteLine("Total de extras: " + totalExtras + " €");
                }

                do
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("PREPARACION DE LA COMPRA");
                    Console.WriteLine("1. Compra normal - Gratis");
                    Console.WriteLine("2. Preparar comprar para regalo - 2 €");
                    Console.WriteLine("Seleciona una opcion");

                    opcionRegalo = int.Parse(Console.ReadLine());
                    
                    if (opcionRegalo < 1 || opcionRegalo > 2)
                    {
                        Console.WriteLine("Opcion no valida");
                    }

                }while (opcionRegalo < 1 || opcionRegalo > 2);
                if (opcionRegalo == 1)
                {
                    tipoCompra = "Compra normal";
                }
                else
                {
                    tipoCompra = "Comprar preparada para este regalo";
                    precioRegalo = 2;
                }
                double subtotal = precio + totalExtras;
                Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");
                Console.WriteLine("SUBTOTAL DE TU COMPRA");
                Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");
                Console.WriteLine("Precio del producto: " + precio.ToString("F2") + " €");
                Console.WriteLine("Precio de los extras: " + totalExtras.ToString("F2") + " €");
                Console.WriteLine("Subtotal: " + subtotal.ToString("F2") + " €");

                double descuento = 0;

                if (subtotal >= 100)
                {
                    descuento = subtotal * 0.10;
                    Console.WriteLine("Descuento aplicado: 10%");
                }
                else
                {
                    Console.WriteLine("No se aplica descuento");
                }
                double totalPagar = subtotal - descuento + precioRegalo;
                Console.WriteLine("Descuento: " + descuento + " €");
                Console.WriteLine("Total a pagar: " + totalPagar + " €");
                Console.WriteLine("Preparacion de la compra: " + precioRegalo + " €");

                double dineroEntregado = 0;

                do
                {
                    Console.WriteLine("Introduce el dinero entregado: ");
                    dineroEntregado = double.Parse(Console.ReadLine());

                    if (dineroEntregado < totalPagar)
                    {
                        Console.WriteLine("Dinero insuficiente. Introduce el importe completo.");
                    }
                } while(dineroEntregado < totalPagar);
                double cambio = dineroEntregado - totalPagar;

                Console.WriteLine("Dinero entregado: " + dineroEntregado + " €");
                Console.WriteLine("Cambio: " + cambio + " €");
                Console.WriteLine("Pago realizado correctamente");
                numeroOperacion++;
                recaudacionTotal = recaudacionTotal + totalPagar;
                if(totalPagar > ventaMasCara)
                {
                    ventaMasCara = totalPagar;
                    clienteVentaMasCara = nombreCliente;
                }

                Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");
                Console.WriteLine(" EL TICKET DE TU COMPRA");
                Console.WriteLine("Operacion numero: " + numeroOperacion);
                Console.WriteLine("Nombre del cliente: " + nombreCliente);
                Console.WriteLine("Producto: " + nombreProducto);
                Console.WriteLine("Talla: " + tallaEscogida);
                Console.WriteLine("Tipo de compra: " + tipoCompra);

                Console.WriteLine("..... EXTRAS .....");
                if (bolsaElegida == true)
                {
                    Console.WriteLine("Bolsa de regalo: 3€");
                    
                }
                if (calcetinesElegidos == true)
                {
                    Console.WriteLine("Pack de calcetines: 5€");
                }
                if (personalizacionElegida == true)
                {
                    Console.WriteLine("Personalizacion: 8€");
                }
                if (cantidadExtras == 0)
                {
                    Console.WriteLine("Sin extras");
                }

                Console.WriteLine("---- DETALLE ECONOMICO DE LA OPERACION ----");
                Console.WriteLine("Precio del producto: " + precio.ToString("F2") + " €");
                Console.WriteLine("Total de extras: " + totalExtras.ToString("F2") + " €");
                Console.WriteLine("Subtotal: " + subtotal.ToString("F2") + " €");
                Console.WriteLine("Descuento: " + descuento.ToString("F2"));
                Console.WriteLine("Preparacion para regalo: " + precioRegalo.ToString("F2") + " €");
                Console.WriteLine("TOTAL PAGADO: " + totalPagar.ToString("F2") + " €");
                Console.WriteLine("Dinero entregado: " + dineroEntregado.ToString("F2") + " €");
                Console.WriteLine("Cambio devuelto: " + cambio.ToString("F2") + " €");
                Console.WriteLine("------------------------------------------------");

                break;
                

            }

        case 2:
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");
                Console.WriteLine(" BALANCE DE LA TIENDA ");
                Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");

                if(numeroOperacion == 0)
                {
                    Console.WriteLine("Todavia no se han realizado operaciones.");
                }
                else
                {
                    Console.WriteLine("Operaciones realizadas: " + numeroOperacion);
                    Console.WriteLine("Recaudacion total: " + recaudacionTotal.ToString("F2") + " €");

                    double importeMedio = recaudacionTotal / numeroOperacion;

                    Console.WriteLine("Importe medio de las ventas: " + importeMedio.ToString("F2") + " €");
                    Console.WriteLine("Venta mas cara de mi tienda: " + ventaMasCara.ToString("F2") + " €");
                    Console.WriteLine("Cliente de la venta mas cara: " + clienteVentaMasCara);
                }
                break;
            }
        case 0:
            {
                Console.WriteLine("Gracias por comprar en Youssef Clothes");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("RESUMEN DEL DIA EN Youssef Clothes");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");
                if(numeroOperacion == 0)
                {
                    Console.WriteLine("No se han realizado ventas. ");

                }
                else
                {
                    Console.WriteLine("Operaciones realizadas: " + numeroOperacion);
                    Console.WriteLine("Recaudacion total: " + recaudacionTotal.ToString("F2") + " €");
                    Console.WriteLine("Venta mas cara: " + ventaMasCara.ToString("F2") + " €");
                    Console.WriteLine("Cliente: " + clienteVentaMasCara);

                    double importeMedio = recaudacionTotal / numeroOperacion;
                    Console.WriteLine("Importe medio de las ventas: " + importeMedio.ToString("F2") + " €");
                
                }
            }
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}

