using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pluse : MonoBehaviour
{

    public int score = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plus")
        {
            score++;
            Destroy(collision.gameObject);
            if (score > 9)
            {
                SceneManager.LoadScene(3);
            }
        }
        else if (collision.gameObject.tag == "Minus")
        {
            score--;
            if (score < 9)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }



    }
}