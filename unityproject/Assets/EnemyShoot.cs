using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;
    public float bulletSpeed = 10f;
    public float bulletLifetime = 1f;
    public float shootDelay = 1f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
       //player.position.x
       //player.position.y
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootDelay)
        {
            timer = 0;
            GameObject EnemyBullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 playerPosition = player.position;
            Debug.Log(playerPosition);
            Vector2 shootDir = new Vector2(playerPosition.x - transform.position.x, playerPosition.y - transform.position.y);
            shootDir.Normalize();
            EnemyBullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(EnemyBullet, bulletLifetime);
        }
    }
}
