using ListaLigada.Logica;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada Simple");
        Console.WriteLine("");

        var singleList = new SingleList<String>();

        int opcion = 0;

        do 
        {
            opcion = Menu();

            switch (opcion) {
                case 1:
                    AgregarElemento();
                    break;

                case 2:
                    MostrarLista();
                    break;

                case 3:
                    EliminarElemento();
                    break;

                case 0:
                    
                    break;
                
                default:
                    Console.WriteLine("Esta opcion no existe");
                    break;
            
            }



        } while (opcion != 0);

        //Se puede quitar private static y el metodo puede crearse de manera directa dentro del main
        //para evitar crear un nuevo objeto una y otra vez
        void AgregarElemento()
        {
            Console.WriteLine("Escribe el nombre del nodo");
            var data = Console.ReadLine();
            singleList.Add(data);

        }

        void MostrarLista() {
            Console.WriteLine(singleList);
        }

        void EliminarElemento(){ 
            
        }



        Console.ReadKey();
    } //Termina el main


    private static int Menu()
    {
        Console.WriteLine("\nMenu\n");
        Console.WriteLine("1.- Agregar elemento");
        Console.WriteLine("2.- Mostrar lista");
        Console.WriteLine("3.- Eliminar elemento");
        Console.WriteLine("0.- Salir\n");

        bool esValido = false;
        //Se puede poner ! en una propiedad, pero como es variable, no hay problema
        int opcion = 0;

        do 
        {
            Console.WriteLine("Elige una opcion del menu");
            var opcionCapturada = Console.ReadLine();

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Digite una opcion valida");
                esValido = false;
            }
            else {
                esValido = true;
            }

        } while (esValido == false);
        return opcion;
    }
}