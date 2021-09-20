using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fruit myFruit = new Fruit();
        Apple myApple = new Apple();

        myFruit.SayHello(myFruit.nombreColor);
        myFruit.Chop();

        myApple.SayHello(myApple.nombreColor);
        myApple.Chop();

        myFruit = new Fruit("Yellow");
        myApple = new Apple("Green");


        myFruit.SayHello(myFruit.nombreColor);
        myFruit.Chop();

        myApple.SayHello(myApple.nombreColor);
        myApple.Chop();

    }

    
}
