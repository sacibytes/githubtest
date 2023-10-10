using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public int scoreToGive = -2;
    public int clickToPop = 1;
    public ScoreManager scoreManager;
    public GameObject effects;
    public bool is_Clicked = false;

    void OnMouseDown()
    {
        AudioManager.instance.Play("tap");

        clickToPop -= 1;

        if (clickToPop == 0)
        {
            scoreManager.IncreaseScore(scoreToGive); 
            Destroy(gameObject);
            Instantiate(effects, transform.position, Quaternion.identity);
            AudioManager.instance.Play("explode");
        }

    }

    public void TakeDamage(float Damage)
    {
        if (gameObject != null)
        {
            // Do something  
            Destroy(gameObject);
        }
    }
}
