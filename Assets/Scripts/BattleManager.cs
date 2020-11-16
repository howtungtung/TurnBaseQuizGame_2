using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public BattleEnemy[] enemyPrefabs;
    public BattleEnemy currentEnemy;
    public Transform spawnPos;
    public Text enemyNameText;
    public HPIndicator hpIndicator;
    public EnemyHPIndicator enemyHPIndicator;
    public CharacterData player;
    public QuizUI quizUI;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return Starting();
        yield return Gaming();
    }

    private IEnumerator Starting()
    {
        //Setup enemy
        BattleEnemy battleEnemyPrefab = Array.Find(enemyPrefabs, data => data.id == DataManager.Instance.battleEnemyData.id);
        currentEnemy = Instantiate(battleEnemyPrefab, spawnPos.position, spawnPos.rotation);
        currentEnemy.enemyData = DataManager.Instance.battleEnemyData;
        enemyNameText.text = currentEnemy.enemyData.name;
        //Setup player
        player.hp = DataManager.Instance.playerHP;
        yield return new WaitForSeconds(8);
        enemyHPIndicator.characterData = currentEnemy.enemyData;
        enemyHPIndicator.gameObject.SetActive(true);
        hpIndicator.gameObject.SetActive(true);
    }

    private IEnumerator Gaming()
    {
        quizUI.Show(DataManager.Instance.quizDatas[0]);
        yield return null;
    }

    public void OnAnswerCorrect()
    {
        Debug.Log("Answer Correct");
    }

    public void OnAnswerWrong()
    {
        Debug.Log("Answer Wrong");
    }
}
