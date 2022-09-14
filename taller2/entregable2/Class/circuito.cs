using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ENTREGABLE2
{

    public class Circuito
    
    {


        List<Carro> Carro { get; set; } = new List<Carro>();

        public int limiteVueltas { get; set; }
        public String NombreCir { get; set; }

        public Circuito(int limiteVueltas, String NombreCir)
        {
            this.limiteVueltas = limiteVueltas;
            this.NombreCir = NombreCir;
        }
        public void AñadirCarro(Carro carro)
        {
            this.Carro.Add(carro);
        }

        public void QuitarCarro(Carro carro)
        {
            try
            {
                this.Carro.Remove(carro);
            }
            catch
            {
                Console.WriteLine("El Carro no esta en este circuito");
            }
        }

        public Dictionary<Carro, int> RealizarPrueba()
        {
            Dictionary<Carro, int> fastesLap = new Dictionary<Carro, int>();
            if (this.Carro.Count > 0)
            {
                return null;
            }

            Console.WriteLine(this.Carro.Count);
            foreach(Carro vec in this.Carro)
            {
                int fastest = 1000000;
                vec.Encender();
                vec.Movimiento();
                for(int i = 0; i < this.limiteVueltas; i++)
                { 
                    Random r = new Random();
                    int lap = r.Next(0, 999999);
                    if (lap < fastest)
                    {
                        fastest = lap;
                    }
                }


                fastesLap.Add(vec, fastest);
                vec.Apagar();
                Console.WriteLine($"Carro {vec.Estado} con el lap {fastest}");
            }
            
            return fastesLap;
     
        }

    }
}