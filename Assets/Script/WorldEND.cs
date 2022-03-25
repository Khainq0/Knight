using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEND : MonoBehaviour
{
    public Player player;
    public int damage = 5;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(damage);
          //  player.Knockback(400f, player.transform.position);
        }
    }
}