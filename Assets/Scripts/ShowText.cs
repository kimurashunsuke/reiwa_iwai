using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    public float delay;
    [SerializeField] GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Show", delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Show()
    {
        text.SetActive(true);
    }
}
