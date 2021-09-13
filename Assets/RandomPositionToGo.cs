using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class RandomPositionToGo : MonoBehaviour
{
    NavMeshAgent agent;
    bool suscrito;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(RandomPos());
        ManagerCapsulas.instance.onCallCapsules += Jump;
        suscrito = true;
    }

    public void Jump()
    {
        agent.isStopped = true;
        transform.DOJump(transform.position, 3,3, 0.5f);
    }

    private void OnMouseDown()
    {
        if(suscrito)
        {
            ManagerCapsulas.instance.onCallCapsules -= Jump;
            suscrito = false;
        }
        else if(!suscrito)
        {
            ManagerCapsulas.instance.onCallCapsules += Jump;
            suscrito = true;
        }
        
    }

    IEnumerator RandomPos()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 2));
            agent.isStopped = false;
            agent.SetDestination(new Vector3(transform.position.x + Random.Range(-4, 4), 
                transform.position.y, transform.position.z + Random.Range(-4, 4)));
        }
    }

}
