using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 100;
    public float timeToDissapear = 5;
    public Vector3 direction = new Vector3(0,0,1);

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    public void OnShoot(Vector3 newDirection)
    {
        direction = newDirection;
        transform.gameObject.SetActive(true);
        StartCoroutine(Dissapear());
    }
    IEnumerator Dissapear()
    {
        
        yield return new WaitForSeconds(timeToDissapear);
        transform.gameObject.SetActive(false);
        yield break;
    }
}
