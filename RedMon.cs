using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMon : MonoBehaviour
{
    public int scoreToGive = 1;
    public int clicksToPop = 2;
    public float scaleIncreasePerClick = 0.5f;
    public ScoreManager scoreManager;
    public GameObject effect;
    public bool is_Clicked = false;

    void OnMouseDown()
    {
        AudioManager.instance.Play("tap");

        clicksToPop -= 1;

        transform.localScale += Vector3.one * scaleIncreasePerClick;

        if (clicksToPop == 0)
        {
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
            AudioManager.instance.Play("pop");
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
