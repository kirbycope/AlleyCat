using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TitleAI : MonoBehaviour
{

    private Animator animator;
    private UnityEngine.AI.NavMeshAgent agent;
    private float? sitTime;
    private Vector3 target;
    private int waypointIndex;

    public float sitWaitTime;
    public Transform[] waypoints;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        // If the target is less than 1 unit away, then increment the index/destination.
        if (Vector3.Distance(transform.position, target) < 1)
        {
            if (sitTime == null)
            {
                // Set sitTime
                sitTime = Time.time;
                // Switch animation to sitting
                animator.SetBool("isMoving", false);
                // Stop the navagation
                agent.isStopped = true;
            }
            // If the sitWaitTime has elapsed, then...
            if (Time.time - sitTime >= sitWaitTime)
            {
                // End sitTime
                sitTime = null;
                // Resume walking animation
                animator.SetBool("isMoving", true);
                // Increment the Waypoint index
                IterateWaypointIndex();
                // Start the navigation
                agent.isStopped = false;
                // Update the new destination
                UpdateDestination();
            }
            
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
