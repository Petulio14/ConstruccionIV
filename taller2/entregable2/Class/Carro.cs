using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ENTREGABLE2.monoplaza;


namespace ENTREGABLE2
{
    public class Carro : monoplaza
    {
        String Tipo { get; set; }
        String Escuderia { get; set; }
        public List<Estado> Estado { get; private set; } = new List<Estado>();

        public Carro(string tipo, string escuderia)
        {
            this.Tipo = tipo;
            this.Escuderia = escuderia;
            this.Estado.Add(ENTREGABLE2.Estado.APAGADO);
        }

        public void Encender()
        {
            if (this.Estado.Contains(ENTREGABLE2.Estado.APAGADO)) {
                this.Estado.Clear();
                this.Estado.Add(ENTREGABLE2.Estado.ENCENDIDO);
                this.Estado.Add(ENTREGABLE2.Estado.PARADO);

                Console.WriteLine($"Encendiendo {this.Tipo}");
                return;
            }

            Console.WriteLine("Apaga el carro");
        }

        public void Apagar()
        {
            if (this.Estado.Contains(ENTREGABLE2.Estado.ENCENDIDO) && this.Estado.Contains(ENTREGABLE2.Estado.PARADO))
            {
                this.Estado.Clear();
                this.Estado.Add(ENTREGABLE2.Estado.APAGADO);
                Console.WriteLine($"Apagando {this.Tipo}");

                return;
            }

            Console.WriteLine("El vehiculo debe estar encendido y parado");

        }

        public void Movimiento()
        {
            if (this.Estado.Contains(ENTREGABLE2.Estado.ENCENDIDO) && this.Estado.Contains(ENTREGABLE2.Estado.PARADO))
            {
                this.Estado.Clear();
                this.Estado.Add(ENTREGABLE2.Estado.MOVIMIENTO);
                this.Estado.Add(ENTREGABLE2.Estado.ENCENDIDO);
                Console.WriteLine($"{this.Tipo} en movimiento");

                return;
            }

            Console.WriteLine("El Carro debe estar encendido y parado");

        }

        public void Detener()
        {
            if (this.Estado.Contains(ENTREGABLE2.Estado.ENCENDIDO) && this.Estado.Contains(ENTREGABLE2.Estado.MOVIMIENTO))
            {
                this.Estado.Clear();
                this.Estado.Add(ENTREGABLE2.Estado.PARADO);
                this.Estado.Add(ENTREGABLE2.Estado.ENCENDIDO);
                Console.WriteLine($"Parando McLaren {this.Tipo}");

                return;
            }

            Console.WriteLine("El vehiculo debe estar encendido y en movimiento");

        }
    }

    public enum Estado
    {
        APAGADO,
        ENCENDIDO, 
        MOVIMIENTO, 
        PARADO
    }
}
