using System;
using System.Collections.Generic;

namespace Pet_Care___Login.AllUserControls
{
    public class Texto
    {
        private LinkedList<string> listaTexto;

        public LinkedListNode<string> FirstLine
        {
            get { return listaTexto.First; }
        }

        public int NumLines
        {
            get { return listaTexto.Count; }
        }

        // Construtor
        public Texto()
        {
            listaTexto = new LinkedList<string>();
        }

        public void InsertLine(string text, int position)
        {
            // Primeiro

            if (position == -1)
                listaTexto.AddFirst(text);

            else
            {
                LinkedListNode<string> p = new LinkedListNode<string>(text);
                listaTexto.AddAfter(listaTexto.Last, text);
            }
        }
    }
}
