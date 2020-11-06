using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyDetailUI : MonoBehaviour
{
    private Vector3 worldPos;
    private Camera cam;
    public Text nameText;
    public Text hpText;
    public Text atkText;
    public Text turnText;
    public GameObject root;

    private void Start()
    {
        cam = Camera.main;
    }

    public void Show(EnemyData data, Vector3 worldPos)
    {
        root.SetActive(true);
        this.worldPos = worldPos;
        nameText.text = data.name;
        hpText.text = "血量 " + data.hp;
        atkText.text = "攻擊力 " + data.atk;
        turnText.text = "回合數 " + data.battleTurn;
    }

    public void Hide()
    {
        root.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (root.activeInHierarchy == false)
            return;
        root.transform.position = cam.WorldToScreenPoint(worldPos);
    }
}
