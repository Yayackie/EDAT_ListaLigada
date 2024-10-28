using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada Simle");
        Console.WriteLine("");

        var singleList = new SingleList<String>();

        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Ian");
        singleList.Add("Luis");
        singleList.Add("Jose");

        Console.WriteLine(singleList);


        Console.ReadKey();
    }
}