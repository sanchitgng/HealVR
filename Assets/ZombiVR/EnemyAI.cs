using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent navMeshAgent;
    Animator animator;

    float distanceToTarget = Mathf.Infinity;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        distanceToTarget = Vector3.Distance(target.position, transform.position);

        //transform.LookAt(target);

        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            animator.SetBool("attack", false);
            animator.SetTrigger("move");
            navMeshAgent.SetDestination(target.position);
        }

        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            animator.SetBool("attack", true);
            Debug.Log(name + " has seeked and is destroying " + target.name);
        }
    }
}
