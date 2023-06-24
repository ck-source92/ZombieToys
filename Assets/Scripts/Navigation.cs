using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Navigation
    : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] float updateDelay = .5f;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        InvokeRepeating("FollowTarget", 0f, updateDelay);
    }

    void FollowTarget()
    {
        agent.SetDestination(target
            .position);
    }

}
