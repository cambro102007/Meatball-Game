using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public EventHandler eventHandler;
    public MeatBall meatBall;

    // Start is called before the first frame update
    void Start()
    {
        eventHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<EventHandler>();
        meatBall = GameObject.FindGameObjectWithTag("Player").GetComponent<MeatBall>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && meatBall.Alive)
        {
            eventHandler.AddScore(1);
        }
    }
}

