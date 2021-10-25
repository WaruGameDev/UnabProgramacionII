using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class JumpPlayer : MonoBehaviour
{
    bool suscrito;
    private void Start()
    {
        ManagerPlayer.instance.onCallPlayer += Jump;
        suscrito = true;
        Cubo cubo = new Cubo();
        cubo.CreateNombreCubo("Juanito");
    }
    public void Jump()
    {
        transform.DOJump(transform.position, FuerzaDeSaltoAleatorio(), 1, .3f);
    }
    private void OnMouseDown()
    {
        transform.DOShakeRotation(.2f);
        if(EstaSuscrito())
        {
            ManagerPlayer.instance.onCallPlayer -= Jump;
            suscrito = false;
        }
        else if(!EstaSuscrito())
        {
            ManagerPlayer.instance.onCallPlayer += Jump;
            suscrito = true;
        }       
    }
    public float FuerzaDeSaltoAleatorio()
    {
        return Random.Range(5, 10);
    }
    bool EstaSuscrito()
    {
        return suscrito;
    }
}
