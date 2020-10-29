using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;
public class DataManager : MonoBehaviour
{
    public static DataManager Instance { private set; get; }
    public TextAsset enemyData;
    public EnemyData[] enemyDatas;

    private void Awake()
    {
        Instance = this;
        enemyDatas = JsonConvert.DeserializeObject<EnemyData[]>(enemyData.text);
    }

    public EnemyData GetEnemyData(int id)
    {
        EnemyData result = Array.Find(enemyDatas, data => data.id == id);
        if (result == null)
            throw new UnityException($"Enemy id {id} was not defined");
        return result.Clone();
    }
}
