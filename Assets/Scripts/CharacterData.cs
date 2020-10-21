using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    public int hp;
    public bool isDead;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void DoDamage(int damage)
    {
        if (isDead)
            return;
        hp -= damage;
        animator.SetTrigger("Hit");
        if(hp <= 0)
        {
            isDead = true;
            animator.SetTrigger("Die");
        }
    }

    public void DoHeal(int heal)
    {
        if (isDead)
            return;
        hp += heal;
    }
}
