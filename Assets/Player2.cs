using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private float speed;
    
    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();        
        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        speed -= 0.001f;
        Vector2 force = new Vector2(speed, 0f);
        myRigidbody.AddForce(force);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "RightWall") {
            SceneManager.LoadScene("Title");
        }
    }
}
