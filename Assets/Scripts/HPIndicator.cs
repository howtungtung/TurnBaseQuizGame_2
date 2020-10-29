using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPIndicator : MonoBehaviour
{
    public CharacterData characterData;
    public Image[] hpImages;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hpImages.Length; i++)
        {
            if (characterData.hp > i)
            {
                hpImages[hpImages.Length - 1 - i].enabled = true;
            }
            else
            {
                hpImages[hpImages.Length - 1 - i].enabled = false;
            }
        }
    }
}
