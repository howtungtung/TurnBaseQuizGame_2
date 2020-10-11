using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    private Camera mainCam;
    private Animator animator;
    private NavMeshAgent agent;
    private CharacterData characterData;

    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        characterData = GetComponent<CharacterData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterData.isDead)
        {
            agent.isStopped = true;
            return;
        }
           
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 50, groundLayer))
            {
                agent.SetDestination(hit.transform.position);
            }
        }
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }
}
