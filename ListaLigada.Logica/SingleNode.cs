namespace ListaLigada.Logica
{
    public class SingleNode <T>
    {
        //Se necesitan las propiedades de Data y el .Next o el puntero que muestra el que sigue
        public T? Data { get; set; }
        //Se hace de tipo SingleNode ya que se desea obtener una direccion de memoria pero de la clase
        public SingleNode <T>? Next { get; set; }
        public SingleNode(T data)
        {
            Data = data;
            Next = null;
        }


    }

}
