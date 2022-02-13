using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ActivateTouchable", 2.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isActive)
        {
            int stageNumber = Random.Range(1, 11);
            SceneManager.LoadScene("Title");
        }
    }
    
    void ActivateTouchable()
    {
        isActive = true;
    }
}
