using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private float speed;
    
    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        speed = -0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        speed -= 0.001f;
        Vector2 force = new Vector2(speed, 0f);
        myRigidbody.AddForce(force);

        if (0 < myRigidbody.velocity.x) {
            Vector2 funbari = new Vector2(-0.05f, 0f);
            myRigidbody.AddForce(funbari);
        } else {
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "GameEndGround") {
            SceneManager.LoadScene("Win");
        }
        if (other.gameObject.name == "Player") {
            speed = 0;
        }
    }
}