using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reply : MonoBehaviour
{
    public bool isCorrect;
    public void ReplyQuestion()
    {
        if(isCorrect)
        {
            print("Correcto");
        }
        else
        {
            print("Ay ay");
        }
    }
}
