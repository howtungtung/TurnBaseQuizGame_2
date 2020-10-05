using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    private Camera mainCam;
    public Animator animator;
    public NavMeshAgent agent;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
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
