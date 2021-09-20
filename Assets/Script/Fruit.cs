using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit 
{
    public string nombreColor;

    public Fruit()
    {
        nombreColor = "orange";
       
    }
    public Fruit(string newColor)
    {
        nombreColor = newColor;
       
    }
    public void Chop()
    {
        Debug.Log("La " + nombreColor + " fruta ha sido cortada.");
    }
    public void SayHello(string nombreFruta)
    {
        Debug.Log("Holi, soy " + nombreFruta + ".");
    }
}
