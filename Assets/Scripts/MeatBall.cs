using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatBall : MonoBehaviour
{
    public float flapStrength = 1.0f;
    public Rigidbody2D birdBody;
    public bool Alive = true;
    public GameObject DeathScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       if (Alive)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                birdBody.velocity = Vector2.up * flapStrength;
            }
        }
    }
    void KillPlayer()
    {
        Alive = false;
        DeathScreen.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deathbox")
        {
            KillPlayer();
        }
    }
}
