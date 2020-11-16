using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPIndicator : MonoBehaviour
{
    public EnemyData characterData;
    public Image[] hpImages;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hpImages.Length; i++)
        {
            if (characterData.hp > i)
            {
                hpImages[i].enabled = true;
            }
            else
            {
                hpImages[i].enabled = false;
            }
        }
    }
}
