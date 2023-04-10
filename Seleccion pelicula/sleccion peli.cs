using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_pelicula
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WindowHeight = 25;  // alto de la ventana           
                Console.WindowWidth = 65; //ancho de la ventana
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Title = "Avance 2 de proyecto";
                Console.Write("\n\tBIENVENIDO A PRIME CINEMA");
                Console.Write("\n\n");

                //Declaracion de variables
                string sucursal;

                Console.WriteLine("\t¿a que sucurlas desea entrar?.");
                Console.WriteLine("\n\t1. Sucursal 1");
                Console.WriteLine("\t2. Sucursal 2");
                Console.WriteLine("\t3. Sucursal 3");
                Console.WriteLine("\t4. Sucursal 4");
                Console.WriteLine("\t5. Sucursal 5");
                Console.WriteLine("\t6. Sucursal 6");
                Console.WriteLine("\t7. Sucursal 7");
                Console.WriteLine("\t8. Sucursal 8");
                Console.WriteLine("\t9. Sucursal 9");
                Console.WriteLine("\t10. Sucursal 10");
                Console.Write("\n\tSeleccione una sucursal:");

                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        //codigo para pantalla de la sucursal 1
                        Console.WriteLine("\n\tBienvenido a la sucursal 1");
                        break;
                    case 2:
                        // Código para la pantalla de la sucursal 2
                        Console.WriteLine("\n\tBienvenido a la sucursal 2");
                        break;
                    case 3:
                        // Código para la pantalla de la sucursal 3
                        Console.WriteLine("\n\tBienvenido a la sucursal 3");
                        break;
                    case 4:
                        // Código para la pantalla de la sucursal 4
                        Console.WriteLine("\n\tBienvenido a la sucursal 4");
                        break;
                    case 5:
                        // Código para la pantalla de la sucursal 5
                        Console.WriteLine("\n\tBienvenido a la sucurlsal 5");
                        break;
                    case 6:
                        // Código para la pantalla de la sucursal 6
                        Console.WriteLine("\n\tBienvenido a la sucursal 6");
                        break;
                    case 7:
                        // Código para la pantalla de la sucursal 7
                        Console.WriteLine("\n\tBienvenido a la sucursal 7");
                        break;
                    case 8:
                        //codigo para la pantalla de la sucursal 8
                        Console.WriteLine("\n\tBienvenido a la sucursal 8");
                        break;
                    case 9:
                        //Codigo para la pantalla de la sucursal 9
                        Console.WriteLine("\n\tBienvenido a la sucursal 9");
                        break;
                    case 10:
                        //codigo para la pantalla de la sucursal 10
                        Console.WriteLine("\n\tBienvenido a la sucursal 10");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor seleccione una de las cuatro sucursales.");
                        break;
                }
                //Inicio de cartelera de cine
                {
                    Console.WriteLine("\n\tBienvenido al cine");
                    Console.WriteLine("\t-------------------");
                    Console.WriteLine("\t1. Jumanji");
                    Console.WriteLine("\t2. Toy Story 4");
                    Console.WriteLine("\t3. Guardianes de la galaxia");
                    Console.WriteLine("\t4. Benji");
                    Console.WriteLine("\t-------------------");

                    Console.Write("\tSeleccione una película (1-4): ");
                    int opcionPelicula = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcionPelicula)
                    {
                        case 1:
                            Console.WriteLine("\n\tJumanji");
                            Console.WriteLine("\t-----------------------");
                            Console.WriteLine("\t1. Sala 1 - 10:00 am");
                            Console.WriteLine("\t2. Sala 2 - 11:30 am");
                            Console.WriteLine("\t3. Sala 3 - 2:00 pm");
                            Console.WriteLine("\t-----------------------");

                            Console.Write("\n\tSeleccione una sala (1-3): ");
                            int opcionSala = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("\n\tHa seleccionado la película 'Jumanji' en la sala " + opcionSala);

                            //COMPRA DE ENTRADAS

                            {
                                // Crear matriz para representar los asientos disponibles
                                bool[,] asientos = new bool[8, 10];

                                // Inicializar todos los asientos como disponibles (true)
                                for (int i = 0; i < 8; i++)
                                {
                                    for (int j = 0; j < 10; j++)
                                    {
                                        asientos[i, j] = true;
                                    }
                                }

                                // Mostrar menú de compra de boletos
                                Console.WriteLine("\n\tBienvenido a PRIMECINEMA!");
                                while (true)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("\n\tSeleccione una opción:");
                                    Console.WriteLine("\t1. Ver asientos disponibles");
                                    Console.WriteLine("\t2. Comprar boletos");
                                    Console.WriteLine("\t3. Salir");
                                    Console.Write("\n\tOpción: ");

                                    // Leer opción del usuario
                                    int boleto;
                                    while (!int.TryParse(Console.ReadLine(), out boleto) || boleto < 1 || boleto > 3)
                                    {
                                        Console.Write("Opción inválida. Ingrese nuevamente: ");
                                    }

                                    if (boleto == 1)
                                    {
                                        // Mostrar asientos disponibles
                                        Console.WriteLine();
                                        Console.WriteLine("\n\tAsientos disponibles:");
                                        Console.WriteLine("\n\t---PANTALLA DE PELICULA---");
                                        Console.WriteLine("\t   A B C D E F G H I J");

                                        for (int i = 0; i < 8; i++)
                                        {
                                            Console.Write("\t");
                                            Console.Write((i + 1) + "  ");
                                            for (int j = 0; j < 10; j++)
                                            {
                                                Console.Write(asientos[i, j] ? "O " : "X ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }

                                    else if (boleto == 2)
                                    {
                                        // Comprar boletos
                                        Console.WriteLine();
                                        Console.Write("\tIngrese la fila del asiento que desea comprar (1-8): ");
                                        int fila;
                                        while (!int.TryParse(Console.ReadLine(), out fila) || fila < 1 || fila > 8)
                                        {
                                            Console.Write("Fila inválida. Ingrese nuevamente: ");
                                        }
                                        Console.Write("\tIngrese la columna del asiento que desea comprar (A-J): ");
                                        char columna;
                                        while (!char.TryParse(Console.ReadLine(), out columna) || columna < 'A' || columna > 'J')
                                        {
                                            Console.Write("Columna inválida. Ingrese nuevamente: ");
                                        }

                                        // Convertir letra de columna a número
                                        int columnaNum = columna - 'A';

                                        // Verificar si el asiento está disponible
                                        if (asientos[fila - 1, columnaNum])
                                        {
                                            // Marcar asiento como ocupado
                                            asientos[fila - 1, columnaNum] = false;
                                            Console.Clear();


                                            //ELECCION DE TIPO DE PELICULA Y METODO DE PAGO
                                            {
                                                Console.WriteLine("\n\tBienvenido al registro de compra de boletos");

                                                // Pedir el nombre del comprador
                                                Console.Write("\n\tIngrese su nombre completo: ");
                                                string nombre = Console.ReadLine();



                                                //Indicacion de precios de boletos
                                                {
                                                    // Definir los precios
                                                    double precio2D = 3.50;
                                                    double precio3D = 5.00;

                                                    // Solicitar el tipo de entrada
                                                    Console.WriteLine("\n\tSeleccione el tipo de entrada:");
                                                    Console.WriteLine("\t1 - 2D ($" + precio2D + ")");
                                                    Console.WriteLine("\t2 - 3D ($" + precio3D + ")");
                                                    Console.Write("\t ¿que formato desea comprar?");
                                                    int tipoEntrada = Convert.ToInt32(Console.ReadLine());

                                                    // Validar el tipo de entrada
                                                    if (tipoEntrada != 1 && tipoEntrada != 2)
                                                    {
                                                        Console.WriteLine("\tTipo de entrada inválido.");
                                                        return;
                                                    }

                                                    // Solicitar la cantidad de entradas
                                                    Console.WriteLine("\n\tIngrese la cantidad de entradas que desea comprar:");
                                                    Console.Write("\t");
                                                    int cantidad = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    // Calcular el pago a pagar
                                                    double pago;
                                                    if (tipoEntrada == 1)
                                                    {
                                                        pago = cantidad * precio2D;
                                                    }
                                                    else
                                                    {
                                                        pago = cantidad * precio3D;
                                                    }

                                                    // Solicitar el dinero entregado
                                                    Console.WriteLine("\n\tEl pago a pagar es: $" + pago);
                                                    Console.WriteLine("\n\tIngrese el dinero entregado:");
                                                    Console.Write("\t");
                                                    double dineroEntregado = Convert.ToDouble(Console.ReadLine());
                                                    Console.Clear();

                                                    // Validar el dinero entregado
                                                    if (dineroEntregado < pago)
                                                    {
                                                        Console.WriteLine("\tDinero insuficiente.");
                                                        return;
                                                    }

                                                    // Calcular el cambio
                                                    double cambio = dineroEntregado - pago;
                                                    Console.WriteLine("\n\tSu cambio es: $" + cambio);
                                                    Console.Write("\n\n*************************************************************");
                                                    Console.Write("\n\t MUCHAS GRACIAS POR SU ATENCION ");
                                                    Console.Write("\n\t PROGRAMA CREADO POR: ");
                                                    Console.Write("\n\t ABNER CANO ");
                                                    Console.Write("\n\t Angel Hernandez ");
                                                    Console.Write("\n\t RICARDO MIRA");
                                                    Console.Write("\n\t Daniel Flores ");
                                                    Console.Write("\n\n*************************************************************");
                                                }




                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo siento, ese asiento ya está ocupado. Por favor seleccione otro.");
                                        }
                                    }
                                    else
                                    {
                                        // Salir del programa
                                        Console.WriteLine();
                                        Console.WriteLine("Gracias por visitar nuestro cine!");
                                        break;
                                    }
                                    return;
                                }

                            }
                            break;

                        case 2:
                            Console.WriteLine("\n\tToy Story 4");
                            Console.WriteLine("\t--------------------");
                            Console.WriteLine("\t1. Sala 1 - 12:30 am");
                            Console.WriteLine("\t2. Sala 2 - 2:00 pm");
                            Console.WriteLine("\t3. Sala 3 - 5:30 pm");
                            Console.WriteLine("\t--------------------");

                            Console.Write("\n\tSeleccione una sala (1-3): ");
                            opcionSala = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("\n\tHa seleccionado la película 'Toy Story 4' en la sala " + opcionSala);
                            //COMPRA DE ENTRADAS

                            {
                                // Crear matriz para representar los asientos disponibles
                                bool[,] asientos = new bool[8, 10];

                                // Inicializar todos los asientos como disponibles (true)
                                for (int i = 0; i < 8; i++)
                                {
                                    for (int j = 0; j < 10; j++)
                                    {
                                        asientos[i, j] = true;
                                    }
                                }

                                // Mostrar menú de compra de boletos
                                Console.WriteLine("\n\tBienvenido a PRIMECINEMA!");
                                while (true)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("\n\tSeleccione una opción:");
                                    Console.WriteLine("\t1. Ver asientos disponibles");
                                    Console.WriteLine("\t2. Comprar boletos");
                                    Console.WriteLine("\t3. Salir");
                                    Console.Write("\n\tOpción: ");

                                    // Leer opción del usuario
                                    int boleto;
                                    while (!int.TryParse(Console.ReadLine(), out boleto) || boleto < 1 || boleto > 3)
                                    {
                                        Console.Write("Opción inválida. Ingrese nuevamente: ");
                                    }

                                    if (boleto == 1)
                                    {
                                        // Mostrar asientos disponibles
                                        Console.WriteLine();
                                        Console.WriteLine("\n\tAsientos disponibles:");
                                        Console.WriteLine("\n\t---PANTALLA DE PELICULA---");
                                        Console.WriteLine("\t   A B C D E F G H I J");

                                        for (int i = 0; i < 8; i++)
                                        {
                                            Console.Write("\t");
                                            Console.Write((i + 1) + "  ");
                                            for (int j = 0; j < 10; j++)
                                            {
                                                Console.Write(asientos[i, j] ? "O " : "X ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }

                                    else if (boleto == 2)
                                    {
                                        // Comprar boletos
                                        Console.WriteLine();
                                        Console.Write("\tIngrese la fila del asiento que desea comprar (1-8): ");
                                        int fila;
                                        while (!int.TryParse(Console.ReadLine(), out fila) || fila < 1 || fila > 8)
                                        {
                                            Console.Write("Fila inválida. Ingrese nuevamente: ");
                                        }
                                        Console.Write("\tIngrese la columna del asiento que desea comprar (A-J): ");
                                        char columna;
                                        while (!char.TryParse(Console.ReadLine(), out columna) || columna < 'A' || columna > 'J')
                                        {
                                            Console.Write("Columna inválida. Ingrese nuevamente: ");
                                        }

                                        // Convertir letra de columna a número
                                        int columnaNum = columna - 'A';

                                        // Verificar si el asiento está disponible
                                        if (asientos[fila - 1, columnaNum])
                                        {
                                            // Marcar asiento como ocupado
                                            asientos[fila - 1, columnaNum] = false;
                                            Console.Clear();


                                            //ELECCION DE TIPO DE PELICULA Y METODO DE PAGO
                                            {
                                                Console.WriteLine("\n\tBienvenido al registro de compra de boletos");

                                                // Pedir el nombre del comprador
                                                Console.Write("\n\tIngrese su nombre completo: ");
                                                string nombre = Console.ReadLine();



                                                //Indicacion de precios de boletos
                                                {
                                                    // Definir los precios
                                                    double precio2D = 3.50;
                                                    double precio3D = 5.00;

                                                    // Solicitar el tipo de entrada
                                                    Console.WriteLine("\n\tSeleccione el tipo de entrada:");
                                                    Console.WriteLine("\t1 - 2D ($" + precio2D + ")");
                                                    Console.WriteLine("\t2 - 3D ($" + precio3D + ")");
                                                    Console.Write("\t ¿que formato desea comprar?");
                                                    int tipoEntrada = Convert.ToInt32(Console.ReadLine());

                                                    // Validar el tipo de entrada
                                                    if (tipoEntrada != 1 && tipoEntrada != 2)
                                                    {
                                                        Console.WriteLine("\tTipo de entrada inválido.");
                                                        return;
                                                    }

                                                    // Solicitar la cantidad de entradas
                                                    Console.WriteLine("\n\tIngrese la cantidad de entradas que desea comprar:");
                                                    Console.Write("\t");
                                                    int cantidad = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    // Calcular el pago a pagar
                                                    double pago;
                                                    if (tipoEntrada == 1)
                                                    {
                                                        pago = cantidad * precio2D;
                                                    }
                                                    else
                                                    {
                                                        pago = cantidad * precio3D;
                                                    }

                                                    // Solicitar el dinero entregado
                                                    Console.WriteLine("\n\tEl pago a pagar es: $" + pago);
                                                    Console.WriteLine("\n\tIngrese el dinero entregado:");
                                                    Console.Write("\t");
                                                    double dineroEntregado = Convert.ToDouble(Console.ReadLine());
                                                    Console.Clear();

                                                    // Validar el dinero entregado
                                                    if (dineroEntregado < pago)
                                                    {
                                                        Console.WriteLine("\tDinero insuficiente.");
                                                        return;
                                                    }


                                                    // Calcular el cambio
                                                    double cambio = dineroEntregado - pago;
                                                    Console.WriteLine("\n\tSu cambio es: $" + cambio);
                                                    Console.Write("\n\n*************************************************************");
                                                    Console.Write("\n\t MUCHAS GRACIAS POR SU ATENCION ");
                                                    Console.Write("\n\t PROGRAMA CREADO POR: ");
                                                    Console.Write("\n\t ABNER CANO ");
                                                    Console.Write("\n\t Angel Hernandez ");
                                                    Console.Write("\n\t RICARDO MIRA");
                                                    Console.Write("\n\t Daniel Flores ");
                                                    Console.Write("\n\n*************************************************************");
                                                }




                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo siento, ese asiento ya está ocupado. Por favor seleccione otro.");
                                        }
                                    }
                                    else
                                    {
                                        // Salir del programa
                                        Console.WriteLine();
                                        Console.WriteLine("Gracias por visitar nuestro cine!");
                                        break;
                                    }
                                    return;
                                }

                            }
                            break;

                        case 3:
                            Console.WriteLine("\n\tGuardianes de la galaxia");
                            Console.WriteLine("\t-----------------");
                            Console.WriteLine("\t1. Sala 2 - 9:00 am");
                            Console.WriteLine("\t2. Sala 3 - 10:00 am");
                            Console.WriteLine("\t3. Sala 4 - 3:30 pm");
                            Console.WriteLine("\t-----------------");

                            Console.Write("\n\tSeleccione una sala (1-3): ");
                            opcionSala = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("\n\tHa seleccionado la película 'Guardianes de la galaxia' en la sala " + opcionSala);
                            //COMPRA DE ENTRADAS

                            {
                                // Crear matriz para representar los asientos disponibles
                                bool[,] asientos = new bool[8, 10];

                                // Inicializar todos los asientos como disponibles (true)
                                for (int i = 0; i < 8; i++)
                                {
                                    for (int j = 0; j < 10; j++)
                                    {
                                        asientos[i, j] = true;
                                    }
                                }

                                // Mostrar menú de compra de boletos
                                Console.WriteLine("\n\tBienvenido a PRIMECINEMA!");
                                while (true)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("\n\tSeleccione una opción:");
                                    Console.WriteLine("\t1. Ver asientos disponibles");
                                    Console.WriteLine("\t2. Comprar boletos");
                                    Console.WriteLine("\t3. Salir");
                                    Console.Write("\n\tOpción: ");

                                    // Leer opción del usuario
                                    int boleto;
                                    while (!int.TryParse(Console.ReadLine(), out boleto) || boleto < 1 || boleto > 3)
                                    {
                                        Console.Write("Opción inválida. Ingrese nuevamente: ");
                                    }

                                    if (boleto == 1)
                                    {
                                        // Mostrar asientos disponibles
                                        Console.WriteLine();
                                        Console.WriteLine("\n\tAsientos disponibles:");
                                        Console.WriteLine("\n\t---PANTALLA DE PELICULA---");
                                        Console.WriteLine("\t   A B C D E F G H I J");

                                        for (int i = 0; i < 8; i++)
                                        {
                                            Console.Write("\t");
                                            Console.Write((i + 1) + "  ");
                                            for (int j = 0; j < 10; j++)
                                            {
                                                Console.Write(asientos[i, j] ? "O " : "X ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }

                                    else if (boleto == 2)
                                    {
                                        // Comprar boletos
                                        Console.WriteLine();
                                        Console.Write("\tIngrese la fila del asiento que desea comprar (1-8): ");
                                        int fila;
                                        while (!int.TryParse(Console.ReadLine(), out fila) || fila < 1 || fila > 8)
                                        {
                                            Console.Write("Fila inválida. Ingrese nuevamente: ");
                                        }
                                        Console.Write("\tIngrese la columna del asiento que desea comprar (A-J): ");
                                        char columna;
                                        while (!char.TryParse(Console.ReadLine(), out columna) || columna < 'A' || columna > 'J')
                                        {
                                            Console.Write("Columna inválida. Ingrese nuevamente: ");
                                        }

                                        // Convertir letra de columna a número
                                        int columnaNum = columna - 'A';

                                        // Verificar si el asiento está disponible
                                        if (asientos[fila - 1, columnaNum])
                                        {
                                            // Marcar asiento como ocupado
                                            asientos[fila - 1, columnaNum] = false;
                                            Console.Clear();


                                            //ELECCION DE TIPO DE PELICULA Y METODO DE PAGO
                                            {
                                                Console.WriteLine("\n\tBienvenido al registro de compra de boletos");

                                                // Pedir el nombre del comprador
                                                Console.Write("\n\tIngrese su nombre completo: ");
                                                string nombre = Console.ReadLine();



                                                //Indicacion de precios de boletos
                                                {
                                                    // Definir los precios
                                                    double precio2D = 3.50;
                                                    double precio3D = 5.00;

                                                    // Solicitar el tipo de entrada
                                                    Console.WriteLine("\n\tSeleccione el tipo de entrada:");
                                                    Console.WriteLine("\t1 - 2D ($" + precio2D + ")");
                                                    Console.WriteLine("\t2 - 3D ($" + precio3D + ")");
                                                    Console.Write("\t ¿que formato desea comprar?");
                                                    int tipoEntrada = Convert.ToInt32(Console.ReadLine());

                                                    // Validar el tipo de entrada
                                                    if (tipoEntrada != 1 && tipoEntrada != 2)
                                                    {
                                                        Console.WriteLine("\tTipo de entrada inválido.");
                                                        return;
                                                    }

                                                    // Solicitar la cantidad de entradas
                                                    Console.WriteLine("\n\tIngrese la cantidad de entradas que desea comprar:");
                                                    Console.Write("\t");
                                                    int cantidad = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    // Calcular el pago a pagar
                                                    double pago;
                                                    if (tipoEntrada == 1)
                                                    {
                                                        pago = cantidad * precio2D;
                                                    }
                                                    else
                                                    {
                                                        pago = cantidad * precio3D;
                                                    }

                                                    // Solicitar el dinero entregado
                                                    Console.WriteLine("\n\tEl pago a pagar es: $" + pago);
                                                    Console.WriteLine("\n\tIngrese el dinero entregado:");
                                                    Console.Write("\t");
                                                    double dineroEntregado = Convert.ToDouble(Console.ReadLine());
                                                    Console.Clear();

                                                    // Validar el dinero entregado
                                                    if (dineroEntregado < pago)
                                                    {
                                                        Console.WriteLine("\tDinero insuficiente.");
                                                        return;
                                                    }

                                                    // Calcular el cambio
                                                    double cambio = dineroEntregado - pago;
                                                    Console.WriteLine("\n\tSu cambio es: $" + cambio);
                                                    Console.Write("\n\n*************************************************************");
                                                    Console.Write("\n\t MUCHAS GRACIAS POR SU ATENCION ");
                                                    Console.Write("\n\t PROGRAMA CREADO POR: ");
                                                    Console.Write("\n\t ABNER CANO ");
                                                    Console.Write("\n\t Angel Hernandez ");
                                                    Console.Write("\n\t RICARDO MIRA");
                                                    Console.Write("\n\t Daniel Flores ");
                                                    Console.Write("\n\n*************************************************************");

                                                }




                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo siento, ese asiento ya está ocupado. Por favor seleccione otro.");
                                        }
                                    }
                                    else
                                    {
                                        // Salir del programa
                                        Console.WriteLine();
                                        Console.WriteLine("Gracias por visitar nuestro cine!");
                                        break;
                                    }
                                    return;
                                }

                            }
                            break;

                        case 4:
                            Console.WriteLine("\n\tBenji");
                            Console.WriteLine("\t----");
                            Console.WriteLine("\t1. Sala 1 - 3:30 pm");
                            Console.WriteLine("\t2. Sala 2 - 5:00 pm");
                            Console.WriteLine("\t3. Sala 4 - 10:00 am");
                            Console.WriteLine("\t--------------------");

                            Console.Write("\n\tSeleccione una sala (1-4): ");
                            opcionSala = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.WriteLine("\n\tHa seleccionado la película 'Benji' en la sala " + opcionSala);
                            //COMPRA DE ENTRADAS

                            {
                                // Crear matriz para representar los asientos disponibles
                                bool[,] asientos = new bool[8, 10];

                                // Inicializar todos los asientos como disponibles (true)
                                for (int i = 0; i < 8; i++)
                                {
                                    for (int j = 0; j < 10; j++)
                                    {
                                        asientos[i, j] = true;
                                    }
                                }

                                // Mostrar menú de compra de boletos
                                Console.WriteLine("\n\tBienvenido a PRIMECINEMA!");
                                while (true)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("\n\tSeleccione una opción:");
                                    Console.WriteLine("\t1. Ver asientos disponibles");
                                    Console.WriteLine("\t2. Comprar boletos");
                                    Console.WriteLine("\t3. Salir");
                                    Console.Write("\n\tOpción: ");

                                    // Leer opción del usuario
                                    int boleto;
                                    while (!int.TryParse(Console.ReadLine(), out boleto) || boleto < 1 || boleto > 3)
                                    {
                                        Console.Write("Opción inválida. Ingrese nuevamente: ");
                                    }

                                    if (boleto == 1)
                                    {
                                        // Mostrar asientos disponibles
                                        Console.WriteLine();
                                        Console.WriteLine("\n\tAsientos disponibles:");
                                        Console.WriteLine("\n\t---PANTALLA DE PELICULA---");
                                        Console.WriteLine("\t   A B C D E F G H I J");

                                        for (int i = 0; i < 8; i++)
                                        {
                                            Console.Write("\t");
                                            Console.Write((i + 1) + "  ");
                                            for (int j = 0; j < 10; j++)
                                            {
                                                Console.Write(asientos[i, j] ? "O " : "X ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }

                                    else if (boleto == 2)
                                    {
                                        // Comprar boletos
                                        Console.WriteLine();
                                        Console.Write("\tIngrese la fila del asiento que desea comprar (1-8): ");
                                        int fila;
                                        while (!int.TryParse(Console.ReadLine(), out fila) || fila < 1 || fila > 8)
                                        {
                                            Console.Write("Fila inválida. Ingrese nuevamente: ");
                                        }
                                        Console.Write("\tIngrese la columna del asiento que desea comprar (A-J): ");
                                        char columna;
                                        while (!char.TryParse(Console.ReadLine(), out columna) || columna < 'A' || columna > 'J')
                                        {
                                            Console.Write("Columna inválida. Ingrese nuevamente: ");
                                        }

                                        // Convertir letra de columna a número
                                        int columnaNum = columna - 'A';

                                        // Verificar si el asiento está disponible
                                        if (asientos[fila - 1, columnaNum])
                                        {
                                            // Marcar asiento como ocupado
                                            asientos[fila - 1, columnaNum] = false;
                                            Console.Clear();


                                            //ELECCION DE TIPO DE PELICULA Y METODO DE PAGO
                                            {
                                                Console.WriteLine("\n\tBienvenido al registro de compra de boletos");

                                                // Pedir el nombre del comprador
                                                Console.Write("\n\tIngrese su nombre completo: ");
                                                string nombre = Console.ReadLine();



                                                //Indicacion de precios de boletos
                                                {
                                                    // Definir los precios
                                                    double precio2D = 3.50;
                                                    double precio3D = 5.00;

                                                    // Solicitar el tipo de entrada
                                                    Console.WriteLine("\n\tSeleccione el tipo de entrada:");
                                                    Console.WriteLine("\t1 - 2D ($" + precio2D + ")");
                                                    Console.WriteLine("\t2 - 3D ($" + precio3D + ")");
                                                    Console.Write("\t ¿que formato desea comprar?");
                                                    int tipoEntrada = Convert.ToInt32(Console.ReadLine());

                                                    // Validar el tipo de entrada
                                                    if (tipoEntrada != 1 && tipoEntrada != 2)
                                                    {
                                                        Console.WriteLine("\tTipo de entrada inválido.");
                                                        return;
                                                    }

                                                    // Solicitar la cantidad de entradas
                                                    Console.WriteLine("\n\tIngrese la cantidad de entradas que desea comprar:");
                                                    Console.Write("\t");
                                                    int cantidad = Convert.ToInt32(Console.ReadLine());
                                                    Console.Clear();

                                                    // Calcular el pago a pagar
                                                    double pago;
                                                    if (tipoEntrada == 1)
                                                    {
                                                        pago = cantidad * precio2D;
                                                    }
                                                    else
                                                    {
                                                        pago = cantidad * precio3D;
                                                    }

                                                    // Solicitar el dinero entregado
                                                    Console.WriteLine("\n\tEl pago a pagar es: $" + pago);
                                                    Console.WriteLine("\n\tIngrese el dinero entregado:");
                                                    Console.Write("\t");
                                                    double dineroEntregado = Convert.ToDouble(Console.ReadLine());
                                                    Console.Clear();

                                                    // Validar el dinero entregado
                                                    if (dineroEntregado < pago)
                                                    {
                                                        Console.WriteLine("\tDinero insuficiente.");
                                                        return;
                                                    }

                                                    // Calcular el cambio
                                                    double cambio = dineroEntregado - pago;
                                                    Console.WriteLine("\n\tSu cambio es: $" + cambio);
                                                    Console.Write("\n\n*************************************************************");
                                                    Console.Write("\n\t MUCHAS GRACIAS POR SU ATENCION ");
                                                    Console.Write("\n\t PROGRAMA CREADO POR: ");
                                                    Console.Write("\n\t ABNER CANO ");
                                                    Console.Write("\n\t Angel Hernandez ");
                                                    Console.Write("\n\t RICARDO MIRA");
                                                    Console.Write("\n\t Daniel Flores ");
                                                    Console.Write("\n\n*************************************************************");

                                                }




                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Lo siento, ese asiento ya está ocupado. Por favor seleccione otro.");
                                        }
                                    }
                                    else
                                    {
                                        // Salir del programa
                                        Console.WriteLine();
                                        Console.WriteLine("Gracias por visitar nuestro cine!");
                                        break;
                                    }
                                    return;
                                }

                            }
                            break;

                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }

                }
            }
        }
    }
    }

