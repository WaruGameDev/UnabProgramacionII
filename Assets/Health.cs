using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Health : MonoBehaviour
{
    public float health = 10;
    public float puntaje = 10;
    public void TakeDamage(float damage)
    {
        health -= damage;
        StartCoroutine(Hurting());
        transform.DOShakePosition(.1f, new Vector3(2, 2, 2));
        if(health <= 0)
        {
            Destroy(gameObject);
            GameManagerOnRails.instance.AddPuntaje(puntaje);
        }    
    }
    IEnumerator Hurting()
    {
        GetComponent<Renderer>().material.DOColor(Color.white, 0.1f);
        yield return new WaitForSeconds(.1f);
        GetComponent<Renderer>().material.DOColor(Color.red, 0.1f);
        yield return new WaitForSeconds(.1f);
        yield break;
    }
}
