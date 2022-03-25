using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCone : MonoBehaviour
{
    public DragonAI dragon;
    public bool isLeft = false;


    private void Awake()
    {
        dragon = gameObject.GetComponentInParent<DragonAI>();

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (isLeft)
                dragon.Attack(false);

            else
                dragon.Attack(true);


        }
    }
}