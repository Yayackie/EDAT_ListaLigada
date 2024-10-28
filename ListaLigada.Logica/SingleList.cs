namespace ListaLigada.Logica
{
    public class SingleList<T>
    {
        //Debe apuntar first a la clase SingleNode, lo que significa que se hace un objeto de tipo
        //SingleNode para trabajar con los nodos. 
        //Se elimina get y set ya que sera privado y otra clase no puede tener acceso
        public SingleNode<T>? _first;
        
        public SingleList() {
            _first = null;
        }
        //Se puede crear una expresion lambda de isEmpty para retornar si el puntero first esta vacia o no
        public bool isEmpty => _first == null;

        public void Add(T item) {
            //Se debe crear el nodo primero para poder utilizarlo
            var node = new SingleNode<T>(item);

            //Si resulta que esta vacio, se puede asignar el first al primer nodo
            if (isEmpty)
            {
                _first = node;
            }
            else {
                //El pointer que debe apuntar a otros nodos se asigna a first si es el primer nodo que se hizo
                var pointer = _first;
                
                //El siguiente while es el que permite mover el pointer de un nodo a otro
                while (pointer!.Next != null) { 
                    pointer = pointer.Next;
                }
                pointer!.Next = node;
            }
        }

        /*
        public bool Remove(T elemento) {
            var pointer = _first;

        }
        */
        public override string ToString() {
            var cadenaLista = string.Empty;
            var pointer = _first;
            while (pointer != null) {
                cadenaLista += $"{pointer.Data}\n";
                pointer = pointer.Next;
            }
            return cadenaLista;
        }
    }
}
