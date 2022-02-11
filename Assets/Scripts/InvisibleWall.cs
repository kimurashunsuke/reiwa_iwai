using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnCollisionEnter2D(Collision2D other)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (other.gameObject.name == "Enemy" || other.gameObject.name == "Player")
		{
			Destroy(this.gameObject, 0);
		}
	}        
}
