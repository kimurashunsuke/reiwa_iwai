using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float angle = Random.value * 10;
            if (transform.rotation.z > 0) {
                transform.Rotate(0, 0, -angle);
            } else {
                transform.Rotate(0, 0, angle);
            }
        }
    }
}
