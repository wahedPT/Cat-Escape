using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnenyM : MonoBehaviour
{
    public GameObject player;
    public float Distance;

    public bool Istaret;
    public NavMeshAgent navMesh;
     void Start()
    {
       
    }

    void Update()
    {
        Distance = Vector3.Distance(player.transform.position, this.transform.position);

        if(Distance<=5)
        {
            Istaret = false;
        }
        if (Distance <= 5)
        {
            Istaret = true;
        }
        if(Istaret)
        {
            navMesh.isStopped = false;
            navMesh.SetDestination(player.transform.position);
        }
        if (!Istaret)
        {
            navMesh.isStopped = true;
        }
    }
   
}
