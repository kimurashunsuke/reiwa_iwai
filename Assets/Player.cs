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
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            speed += 8;
            Vector2 force = new Vector2(speed, 0f);
            myRigidbody.AddForce(force);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "GameEndGround") {
            SceneManager.LoadScene("Title");
        }
        if (other.gameObject.name == "Enemy") {
            GetComponent<AudioSource>().PlayOneShot(audioClip);
        }
    }
}
