namespace ENTREGABLE2P2.Class;
using ENTREGABLE2P2.Interface;



public class Pastel{
    
    public string nombre;

    public float tamaño;

    public string listaIngredientes;


    public Pastel(){

    }

    public Pastel(String nombrePastel, float tamañoPastel, string listaIngredientesPastel){

        nombre=nombrePastel;
        tamaño=tamañoPastel;
        listaIngredientes=listaIngredientesPastel;

    }

}