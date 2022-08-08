using System;
using System.IO;

namespace Num1
{
    class Program
    {
        static void Main(string[] args)
        {
            // MENU CREACION DE LISTAS Y VARIABLES (NO SON TODAS ALGUNAS SE HAN CREADO AHI MISMO)//
            List<int> listacosb = new List<int>();
            List<int> listacost = new List<int>();
            


            string respuesta = "0";
            double deposito;
            double cambio;
            


            // MENU //
            Console.WriteLine("Bienvenido a los Tacos de Compas pasale joven");
            Console.WriteLine("A continuación se desplegará el menu");
            Console.WriteLine("");
            Console.WriteLine("****************************************************MENÚ****************************************************");
            Console.WriteLine("");
            Console.WriteLine("ORDEN DE TACOS DE MAÍZ");
            Console.WriteLine("");
            Console.WriteLine("N.P. 1 - Orden de Bisteck a $50");
            Console.WriteLine("N.P. 2 - Orden de Trompo a $50");
            Console.WriteLine("");
            Console.WriteLine("TACOS DE HARINA");
            Console.WriteLine("");
            Console.WriteLine("N.P. 3 - Campechana a $25");
            Console.WriteLine("N.P. 4 - Gringa a $25");
            Console.WriteLine("N.P. 5 - Pirata a $25");
            Console.WriteLine("************************************************************************************************************");


            // AGREGADO DE ITEMS DENTRO DE LAS LISTAS YA CREADAS (LISTAS CREADAS HASTA ARRIBA)//

            while (respuesta != "1")
            {
                Console.WriteLine("¿Que desea llevar? NOTA: USE LAS TECLAS DEL TECLADO DEL 1 AL 5");
                int valor = Convert.ToInt32(Console.ReadLine());


                if (valor == 1)
                {
                    Console.WriteLine("Has escogido: Orden de bisteck");
                    Console.WriteLine("¿Cuantas ordenes vas a llevar?");
                    int cantidad1 = Convert.ToInt32(Console.ReadLine());
                    listacosb.Add(cantidad1);
                    Console.WriteLine("¿Desea pagar su monto total? Escriba 1 para PAGAR ó Si desea seguir comprando escriba cualquier tecla");
                    respuesta = Console.ReadLine();

                    
                }


                if (valor == 2)
                {
                    Console.WriteLine("Has escogido: Orden de Trompo");
                    Console.WriteLine("¿Cuantas ordenes vas a llevar?");
                    int cantidad2 = Convert.ToInt32(Console.ReadLine());
                    listacost.Add(cantidad2);
                    Console.WriteLine("¿Desea pagar su monto total? Escriba 1 para PAGAR ó Si desea seguir comprando escriba cualquier tecla");
                    respuesta = Console.ReadLine();
                }

                //FALTA POR AÑADIR PRODUCTOS PERO YA FUNCIONA EL SISTEMA Y AGREGA TODO BIEN

            }

            // SUMA DE ITEMS DE LA LISTAS CREADAS DE CADA UNO DE LOS PRODUCTOS//
            int suma = 0;
            int suma2 = 0;

            foreach (int i in listacosb)
            {
                suma = suma + i;
            }

            foreach (int i2 in listacost)
            {
                suma2 = suma2 + i2;
            }



            //Limpiar consola//
            Console.Clear();


            // CARRITO Y MULTIPLICACION DEL TOTAL//

            Console.WriteLine("");
            Console.WriteLine("HAS ESCOGIDO: (PROCEDER AL PAGO) ");
            Console.WriteLine("SU CARRITO SERÍA LO SIG:");
            Console.WriteLine("");
            Console.WriteLine("****************************************************CARRITO****************************************************");
            // se utiliza un if y else en dado caso que el usuario introduzca menos de 1 para ahorrar espacio en la terminal
            if (suma >= 1)
            {
                Console.WriteLine("");
                Console.WriteLine(" ||Tacos de Bisteck|| " + " ||Cantidad de Ordenes: " + (suma) + "|| " + " ||Precio Total $" + (suma * 50) + "|| ");
                Console.WriteLine("");
            }
            else
            {
                // no hay nada aqui para reducir el espacio en dado caso que el cliente no compre tacos de ese tipo
            }

            if (suma2 >= 1)
            {
                
                Console.WriteLine(" ||Tacos de Trompo|| " + " ||Cantidad de Ordenes: " + (suma2) + "|| " + " ||Precio Total $" + (suma2 * 50) + "|| ");
                Console.WriteLine("");
            }
            else
            {
                // no hay nada aqui para reducir el espacio en dado caso que el cliente no compre tacos de ese tipo
            }


            // suma de monto a pagar para poder hacerlo sencillo y confirmar compra
            double montoapagar;
            montoapagar = (suma * 50 + suma2 * 50);

            Console.WriteLine(" || MONTO A PAGAR || : $" + (montoapagar));
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("¿Desea confirmar la compra? Escriba 1 PARA CONFIRMAR , Escriba 2 para SALIR");
            int confirmarcompra = Convert.ToInt32(Console.ReadLine());
            if (confirmarcompra == 1)
            {

                Console.WriteLine("Escriba el monto a depositar");
                deposito = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Su cambio sería de: $" + (deposito - montoapagar));
                Console.WriteLine("");
                Console.WriteLine("Guardando en la base de datos...");
                Console.WriteLine("Imprimiendo TICKET...");

                //Guardando Ticket en el bloc de notas//

                try
                {

                    // para escribir texto nuevo  (quita el anterior)
                    /*StreamWriter sw = new StreamWriter("C:\\Users\\orlan\\Desktop\\Orlando\\6.-Semestre\\Programacion de Aplicaciones\\C#- Proyecto1- TIENDA\\Tickets.txt");
                    sw.WriteLine("Bienvenido al texto");
                    sw.WriteLine("Aquí puedes almacenar texto fijo o dinámico usando variablessss2");
                    sw.Close(); */
                    
                    // para escribir texto dinamico y no se quite el anterior 
                    StreamWriter agregar = File.AppendText("C:\\Users\\orlan\\Desktop\\Orlando\\6.-Semestre\\Programacion de Aplicaciones\\C#- Proyecto1- TIENDA\\Tickets.txt");
                    //
                    agregar.WriteLine("************************************************TICKET******************************************************");
                    agregar.WriteLine("                                            TACOS DE COMPAS                                                 ");
                    agregar.WriteLine("");
                    if (suma >= 1)
                    {
                        agregar.WriteLine(" ||Tacos de Bisteck|| " + " ||Cantidad de Ordenes: " + (suma) + "|| " + " ||Precio por Unidad $50|| " + " ||Precio Total $" + (suma * 50) + "|| ");
                        agregar.WriteLine("");
                    }
                    else
                    {
                        // no hay nada aqui para reducir el espacio en dado caso que el cliente no compre tacos de ese tipo
                    }

                    if (suma2 >= 1)
                    {

                        agregar.WriteLine(" ||Tacos de Trompo|| " + " ||Cantidad de Ordenes: " + (suma2) + "|| " + " ||Precio por Unidad $50|| " + " ||Precio Total $" + (suma2 * 50) + "|| ");
                        agregar.WriteLine("");
                        
                    }

                    else
                    {
                        // no hay nada aqui para reducir el espacio en dado caso que el cliente no compre tacos de ese tipo
                    }
                    agregar.WriteLine("Precio Total: $" + montoapagar);
                    agregar.WriteLine("Monto Depositado: $" + deposito);
                    agregar.WriteLine("Cambio al Cliente: $" + (deposito - montoapagar));
                    agregar.WriteLine("");
                    agregar.WriteLine("                                            TACOS DE COMPAS                                                 ");
                    agregar.WriteLine("************************************************TICKET******************************************************");
                    agregar.Close();





                // POR SI LLEGA HABER UN ERROR
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("El archivo se ha guardado con éxito");
                }

            }

            // EN DADO CASO QUE EL USUARIO DE 2, LA CONSOLA ESCRIBE "SALIENDO DEL SISTEMA" Y EL USUARIO TENDRÁ QUE DAR ENTER Y VOLVER A EJECUTAR EL PROGRAMA
            if (confirmarcompra == 2)
            {
                Console.WriteLine("Saliendo Del Sistema");
            }


            // PARA QUE NO SALGA LO DE ABAJO
            Console.ReadKey();

        }

    }
}
    