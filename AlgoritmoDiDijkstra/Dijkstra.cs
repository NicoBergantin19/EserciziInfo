using System;
using System.Collections.Generic;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {           
            for (int i = 0; i < 100; i++)
            {
                Nodo nodo = new Nodo("10.0.0.0", "Rovigo");
                Console.WriteLine(Nodo.posizione + " " + Nodo.id);
            }
            Console.ReadKey();
        }

        internal void Algoritmo(List<Arco> archetto, List<Nodo> nodo)
        {
            //Inizializza il nodo di partenza: il primo della lista.
            archetto[0].costo = 0;
            while(nodo.Where(x => !x.ultimo).Count() != 0)
            {
                //seleziona il nodo con la distanza inferiore 
                int node = nodo.Where(x => !x.ultimo).OrderBy(x => x.costo).FirstOrDefault();
                if(node != null)
                {
                    //Questo diventa l'ultimo nodo   
                    node.ultimo = true;
                    List<Nodo> LinkedNodes = archetto.Where(x => x.n1.node == node.Nodo).Select(x => x.n2).Where(x => x.ultimo == false).ToList();
                    //Per tutti i nodi collegati
                    foreach (List<Nodo> linked in LinkedNodes)
                    {
                        //calcolo distanza
                        int distanza = node.costo + architetto.Where(x => x.n1 == node && x.n2 == linked).First().costo;

                        //Se la distanza calcolata è migliore
                        if(distanza < linked.costo){
                            //Aggiornamento del linked
                            linked.costo = distanza;
                            
                        }
                    } 
                }
            }

        }
    }

    class Nodo{
        static int posizione;
        public int id;
        public string ipAddress;
        public  string citta;
        public List<Nodo> verso;
        public bool ultimo;
        public Nodo(string ipAddress, string citta)
        {
            this.citta = citta;
            this.ipAddress = ipAddress;
            id = Nodo.posizione++;
        }
        public int Id{get => id;}
        public string IpAddress{get => ipAddress; set => ipAddress = value;}
        public string Citta{get => citta; set => citta = value;}
    }

    class Arco{
        Nodo n1;
        Nodo n2;
        int costo;
        public Arco(Nodo n1, Nodo n2, int costo){
            this.n1 = n1;
            this.n2 = n2;
            this.costo = costo;
        }
    }

    class Grafo{
        string descrizione;
        List<Arco> Archi;
    }
}