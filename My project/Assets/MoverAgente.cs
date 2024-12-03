using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoverAgente : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destino;
    void Start()
    {
        if (agent == null) agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destino != null)
            agent.SetDestination(destino.position);
        
    }
}
