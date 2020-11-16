using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;
public class DataManager : MonoBehaviour
{
    public static DataManager Instance { private set; get; }
    public TextAsset enemyData;
    public TextAsset quizData;
    public QuizData[] quizDatas;
    public EnemyData[] enemyDatas;
    public Dictionary<int, EnemyData> levelEnemyData = new Dictionary<int, EnemyData>();
    public EnemyData battleEnemyData;
    public int playerHP;

    private void Awake()
    {
        Instance = this;
        enemyDatas = JsonConvert.DeserializeObject<EnemyData[]>(enemyData.text);
        quizDatas = JsonConvert.DeserializeObject<QuizData[]>(quizData.text);
        DontDestroyOnLoad(gameObject);
    }

    public EnemyData GetEnemyData(int id, int serialNumber)
    {
        if (levelEnemyData.ContainsKey(serialNumber))
        {
            return levelEnemyData[serialNumber];
        }
        else
        {
            EnemyData result = Array.Find(enemyDatas, data => data.id == id);
            if (result == null)
                throw new UnityException($"Enemy id {id} was not defined");
            levelEnemyData[serialNumber] = result.Clone();
            return levelEnemyData[serialNumber];
        }
    }
}
