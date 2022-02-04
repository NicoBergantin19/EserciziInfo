using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikstraClasse5E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Costruzione grafo
            Grafo grafo = new Grafo();
            grafo.AddArco(0, 4, 6);
            grafo.AddArco(0, 6, 2);
            grafo.AddArco(0, 3, 2);
            grafo.AddArco(0, 1, 9);
            grafo.AddArco(0, 2, 1);
            grafo.AddArco(1, 5, 1);
            grafo.AddArco(1, 3, 4);
            grafo.AddArco(1, 0, 9);
            grafo.AddArco(2, 3, 4);
            grafo.AddArco(2, 5, 1);
            grafo.AddArco(2, 0, 1);
            grafo.AddArco(3, 6, 9);
            grafo.AddArco(3, 5, 2);
            grafo.AddArco(3, 1, 4);
            grafo.AddArco(3, 0, 2);
            grafo.AddArco(4, 5, 1);
            grafo.AddArco(4, 0, 6);
            grafo.AddArco(5, 6, 2);
            grafo.AddArco(5, 3, 2);
            grafo.AddArco(5, 4, 1);
            grafo.AddArco(5, 2, 1);

            foreach (Nodo nodo in grafo.Nodi)
            {
                Console.WriteLine("\nNODO => {0}", nodo.ToString());
                foreach (Arco a in nodo.Destinazioni)
                    Console.WriteLine(a.ToString());
            }
            List<Arco> listaArchi = new List<Arco>();
            List<StrArco> listaStrArco = new List<StrArco>();

            //Mostro a schermo tutti i nodi e le destinazioni
            for (int i = 0; i < grafo.Nodi.Count; i++)
            {
                Nodo n = grafo.Nodi[i];
                Console.WriteLine($"\nSTAMPA DELLE DESTINAZIONI DEL NODO {i}");
                foreach (Arco a in n.Destinazioni)
                {
                    listaArchi.Add(a);
                    StrArco str = a.EstraiArco();
                    str.N1 = n.Key;
                    listaStrArco.Add(str);

                    Console.WriteLine(str);
                    Console.WriteLine(a);
                }
            }
                       
            //Stampa archi
            listaArchi.Sort();
            Console.WriteLine("\nSTAMPA ARCHI ORDINATI");
            foreach (Arco a in listaArchi)
            {
                Console.WriteLine(a);
            }

            //Stampa tutti i percorsi migliori 
            Console.WriteLine("\nPERCORSI MIGLIORI");



            Console.ReadKey();
        }
    }
    class Nodo
    {

        public static int i; //Primary Key
        int key;
        List<Arco> destinazioni;//Arco costo e Nodo dest
        bool visitato;
        public Nodo() : this(i++)
        {

        }
        public Nodo(int key)
        {
            this.key = key;
            destinazioni = new List<Arco>();
            visitato = false;
        }
        public Nodo(Nodo n) : this(n.key)
        {

        }
        public bool AddArco(Nodo nodo, int costo)
        {
            if (destinazioni.Exists(d => d.NodoDestinazione == nodo))
                return false;
            destinazioni.Add(new Arco(nodo, costo));
            return true;
        }

        #region "Gestione dell'uguaglianza tra due nodi stessa key"
        public static bool operator ==(Nodo n1, Nodo n2)
        {
            return (n1.Key == n2.Key);

        }
        public static bool operator !=(Nodo n1, Nodo n2)
        {
            return !(n1 == n2);
        }
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return this == (Nodo)obj;

        }

        public override int GetHashCode()
        {
            int hashCode = Key.GetHashCode();
            return hashCode;
        }
        #endregion
        public override string ToString()
        {
            return string.Format("nodo.key: {0}", Key);
        }

        public int Key { get => key; }
        internal List<Arco> Destinazioni { get => destinazioni; }
        public bool Visitato { get => visitato; set => visitato = value; }
    }
    class Arco : IComparable<Arco>, IEquatable<Arco>
    {
        int costo;
        Nodo nodoDestinazione;
        /// <summary>
        /// Costruttore con Nodo di destinazione e costo dell'arco
        /// </summary>
        /// <param name="nodoDestinazione">nodo di collegamento</param>
        /// <param name="costo">Costo del cammino</param>
        public Arco(Nodo nodoDestinazione, int costo)
        {
            this.costo = costo;
            this.nodoDestinazione = nodoDestinazione;

        }
        #region "SORT"
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;

            Arco objAsArco = obj as Arco;
            if (objAsArco == null)
                return false;
            return Equals(objAsArco);
        }
        public int CompareTo(Arco a)
        {
            if (a is null)
                return 1;
            else
                return this.costo.CompareTo(a.costo);
        }
        public override int GetHashCode()
        {
            return costo;
        }
        public bool Equals(Arco a)
        {
            if (a is null)
                return false;
            else
                return this.costo.Equals(a.costo);
        }
        #endregion

        internal Nodo NodoDestinazione { get => nodoDestinazione; }

        public override string ToString()
        {
            string tmp = "";
            tmp = string.Format("Destinazione: {0}, costo: {1}", nodoDestinazione, costo);
            return tmp;
        }
        public StrArco EstraiArco()
        {
            StrArco str = new StrArco();
            str.Costo = this.costo;
            str.N2 = this.NodoDestinazione.Key;
            return str;
        }
    }
    class Grafo
    {
        List<Nodo> nodi; //Tutti i nodi del grafo 
        public Grafo()
        {
            nodi = new List<Nodo>();

            #region "AddArchi"
            /*
            AddArco(0, 4, 6);
            AddArco(0, 6, 2);
            AddArco(0, 3, 2);
            AddArco(0, 1, 9);
            AddArco(1, 5, 1);
            AddArco(1, 3, 4);
            AddArco(2, 3, 4);
            AddArco(2, 5, 1);
            AddArco(3, 6, 9);
            AddArco(3, 5, 2);
            AddArco(4, 5, 1);
            AddArco(5, 6, 2);
            */
            #endregion
        }
        public bool AddArco(int key1, int key2, int costo)
        {

            Nodo n1;
            Nodo n2;
            n1 = nodi.Find(n => n.Key == key1);
            if (n1 is null)
            {
                n1 = new Nodo(key1);
                nodi.Add(n1);
            }

            n2 = nodi.Find(n => n.Key == key2);
            if (n2 is null)
            {
                n2 = new Nodo(key2);
                nodi.Add(n2);
            }

            return (n1.AddArco(n2, costo) && n2.AddArco(n1, costo));
        }
        internal List<Nodo> Nodi { get => nodi; }
        public bool AddNodo(Nodo n)
        {
            if (nodi.Exists(d => d.Key == n.Key))
                return false;
            nodi.Add(n);
            return true;
        }
        public int[,] EstraiNodi()
        {
            int[,] vn = new int[nodi.Count, 2];
            int i = 0;
            foreach (Nodo n in nodi)
            {
                vn[i++, 0] = n.Key;
                //vn[i, 1] = 1;

            }
            return vn;
        }

        public void CalcoloPercorsoMigliore()
        {

        }
    }
    struct StrArco
    {
        int n1, n2, costo;
        public override string ToString()
        {
            return string.Format("n1: {0}, n2: {1}, costo: {2}", n1, n2, costo);
        }
        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }
        public int Costo { get => costo; set => costo = value; }
    }
}