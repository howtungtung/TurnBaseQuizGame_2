using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnemyBahavior : MonoBehaviour
{
    public int id;
    public EnemyData enemyData;
    private TransitionManager transitionManager;

    private void Start()
    {
        transitionManager = GameObject.FindObjectOfType<TransitionManager>();
        enemyData = DataManager.Instance.GetEnemyData(id);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transitionManager.ChangeScene("BattleScene");
        }
    }

    private void OnMouseEnter()
    {
        Debug.Log(name);
    }
}
