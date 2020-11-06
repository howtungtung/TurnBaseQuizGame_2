using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BattleManager : MonoBehaviour
{
    public BattleEnemy[] enemyPrefabs;
    public BattleEnemy currentEnemy;
    public Transform spawnPos;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return Starting();
    }

    private IEnumerator Starting()
    {
        BattleEnemy battleEnemyPrefab = Array.Find(enemyPrefabs, data => data.id == DataManager.Instance.battleEnemyData.id);
        currentEnemy = Instantiate(battleEnemyPrefab, spawnPos.position, spawnPos.rotation);
        currentEnemy.enemyData = DataManager.Instance.battleEnemyData;
        yield return null;
        //
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
