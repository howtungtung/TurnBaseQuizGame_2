using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnemyBahavior : MonoBehaviour
{
    private TransitionManager transitionManager;

    private void Start()
    {
        transitionManager = GameObject.FindObjectOfType<TransitionManager>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transitionManager.ChangeScene("BattleScene");
        }
    }
}
