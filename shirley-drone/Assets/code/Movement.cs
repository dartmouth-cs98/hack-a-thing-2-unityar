using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


    //destination marker reference
    public GameObject markerGoal;
    //parent position
    Vector3 parentPos;
    //navmesh component reference
    UnityEngine.AI.NavMeshAgent agent;


    // Use this for initialization
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void MoveToTarget()
    {
        if (markerGoal.activeInHierarchy)
        {
            parentPos = markerGoal.transform.parent.position;
            agent.SetDestination(parentPos);
        }
    }


    private void Update()
    {
        MoveToTarget();
    }
}
