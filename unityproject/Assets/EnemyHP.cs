using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public int enemyhealth = 10;

    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            enemyhealth--;




        }
        if (enemyhealth < 1)//health < 1
        {
            Destroy(gameObject);
        }
    }
}

