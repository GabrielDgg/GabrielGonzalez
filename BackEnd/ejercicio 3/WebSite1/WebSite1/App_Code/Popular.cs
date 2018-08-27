using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Class1
/// </summary>
public class Popular    
{
    private int numero;
    private int poularidad;

    public int Popularidad
    {
        get { return poularidad; }
        set { poularidad = value; }
    }

    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public Popular(int numero)
    {
        this.numero = numero;
    }

    public Popular(int popularidad, int numero)
    {
        this.poularidad = popularidad;
        this.numero = numero;
    }

    public Popular()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public  void metodo() { }
}