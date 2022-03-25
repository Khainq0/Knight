using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOX1 : MonoBehaviour
{
    public int Health = 100;
    public bool death = false;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        anim = gameObject.GetComponent<Animator>();
        if (Health <= 0)
        {
            death = true;
            anim.SetBool("Death", death);
            Destroy(gameObject, 1);
        }
    }

    void Damage(int damage)
    {
        Health -= damage;
    }
}