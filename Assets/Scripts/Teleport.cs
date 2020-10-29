using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Teleport : MonoBehaviour
{
    public Teleport exit;
    private bool disableTeleport;

    private void OnTriggerEnter(Collider other)
    {
        if (disableTeleport)
            return;
        if (other.CompareTag("Player"))
        {
            exit.disableTeleport = true;
            //other.transform.position = exit.transform.position;
            other.GetComponent<NavMeshAgent>().Warp(exit.transform.position);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            disableTeleport = false;
        }
    }
}
