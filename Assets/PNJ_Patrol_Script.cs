using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PNJ_Patrol_Script : MonoBehaviour
{

    NavMeshAgent agent;
    public Transform[] wayPoints;
    int wayPointsIndex;
    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void UpdateDestination()
    {
        target = wayPoints[wayPointsIndex].position;
        agent.SetDestination(target);
    }

    void InterateWayPointIndex()
    {
        wayPointsIndex++;
        if (wayPointsIndex == wayPoints.Length)
        {
            wayPointsIndex = 0;
        }

    }


}
