using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : CuboStandart
{
    public string nameCubo;
    public void SayName()
    {
        base.CreateNombreCubo(nameCubo);
    }
   
}
