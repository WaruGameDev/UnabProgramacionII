using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerOnRails : MonoBehaviour
{
    public static GameManagerOnRails instance;
    public TextMeshProUGUI puntajeText;
    public float puntaje;

    private void Awake()
    {
        instance = this;
    }
    public void AddPuntaje(float puntajeASumar)
    {
        puntaje += puntajeASumar;
    }
    private void Update()
    {
        puntajeText.text = puntaje.ToString();
    }


}
