using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private float speed;
    private AudioClip audioClip;
    void Start()
    {
        audioClip = gameObject.GetComponent<AudioSource> ().clip;

        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>(); 

        speed += 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.001f;
        Vector2 force = new Vector2(speed, 0f);
        myRigidbody.AddForce(force);
        if (Input.GetKeyDown("space"))
        {
            if (myRigidbody.velocity.x < 2f) {
                Vector2 funbari = new Vector2(myRigidbody.velocity.x + 20, 0f);
                myRigidbody.AddForce(funbari);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "GameEndGround") {
            SceneManager.LoadScene("Lose");
        }
        if (other.gameObject.name == "Enemy") {
            speed = 0;
            GetComponent<AudioSource>().PlayOneShot(audioClip);
        }
    }
}
