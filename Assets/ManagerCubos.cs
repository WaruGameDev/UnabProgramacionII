using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerCubos : MonoBehaviour
{
    public GameObject cuboGenerado;
    public System.Action<float> onCallCubos;

    public static ManagerCubos instance;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            /*Ray ray = new Ray(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);*/
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(cuboGenerado, hit.point /*+ new Vector3(0, 1, 0)*/, Quaternion.identity);
            }

        }
    }
    public void CallCubos()
    {
        onCallCubos?.Invoke(Random.Range(100,400));
    }
}
