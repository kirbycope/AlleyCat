using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TruckAI : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;
    private Vector3 target;
    private int truckpointIndex;

    public Transform[] truckpoints;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        // If the target is less than 1 unit away, then increment the index/destination.
        if (Vector3.Distance(transform.position, target) < 1)
        {
            // Increment the Truckpoint index
            IterateTruckpointIndex();
            // Update the new destination
            UpdateDestination();
        }
        target = truckpoints[truckpointIndex].position;
        transform.LookAt(target);
        transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
    }

    void UpdateDestination()
    {
        target = truckpoints[truckpointIndex].position;
        agent.SetDestination(target);
    }

    void IterateTruckpointIndex()
    {
        truckpointIndex++;
        if (truckpointIndex >= truckpoints.Length)
        {
            truckpointIndex = 0;
        }
    }
}
