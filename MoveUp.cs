using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed = 2.0f;
    public float xPos;
    public Vector3 desiredPos;
    float timer;
    float timerSpeed;
    float timeToMove;


    void Start()
    {
        xPos = Random.Range(-4.5f, 4.5f);
        desiredPos = new Vector3(xPos, transform.position.y, transform.position.z);
    }

    void Update()
    {
      
        GetComponent<Rigidbody>().velocity = new Vector3(0, 15, 0);

        timer += Time.deltaTime * timerSpeed;
        /*if (timer >= timeToMove)
        {
            transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
             if(Vector3.Distance(transform.position, desiredPos) <= 0.04f)
            {
                xPos = Random.Range(-4.5f, 4.5f);
                desiredPos = new Vector3(xPos, transform.position.y, transform.position.z);
                timer = 3.5f;
            }
        }*/
    }
    

}

