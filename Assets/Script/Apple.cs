using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    public Apple()
    {
        nombreColor = "rojo";
    }
    public Apple(string newColor) : base(newColor)
    {
        //segundo constructor.
        
    }
}
