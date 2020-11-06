using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnemyBahavior : MonoBehaviour
{
    public int id;
    public int serialNumber;
    public EnemyData enemyData;
    private TransitionManager transitionManager;
    private EnemyDetailUI enemyDetailUI;

    private void Start()
    {
        transitionManager = GameObject.FindObjectOfType<TransitionManager>();
        enemyData = DataManager.Instance.GetEnemyData(id, serialNumber);
        enemyDetailUI = GameObject.FindObjectOfType<EnemyDetailUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DataManager.Instance.battleEnemyData = enemyData;
            transitionManager.ChangeScene("BattleScene");
        }
    }

    private void OnMouseEnter()
    {
        enemyDetailUI.Show(enemyData, transform.position);
    }

    private void OnMouseExit()
    {
        enemyDetailUI.Hide();
    }
}
