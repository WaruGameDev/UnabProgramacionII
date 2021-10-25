using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithPooling : MonoBehaviour
{
    public GameObject bullet;
    public List<GameObject> bulletPool;
    public int poolSize = 100;
    public List<Transform> canones;
    public Transform airwing;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bulletGo  = Instantiate(bullet, Vector3.zero, Quaternion.identity);
            bulletPool.Add(bulletGo);
            bulletGo.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }

    }
    void Shoot()
    {
        foreach(Transform canon in canones)
        {
            Vector3 localForward = airwing.worldToLocalMatrix.MultiplyVector(airwing.forward);
            bulletPool[0].GetComponent<Bullet>().OnShoot(airwing.forward);        
            bulletPool.Insert(bulletPool.Count - 1, bulletPool[0]);      
            bulletPool[0].transform.position = canon.position;
            bulletPool.RemoveAt(0);
        }
    }
}
