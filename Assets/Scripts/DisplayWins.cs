using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWins : MonoBehaviour
{
    public Text wins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wins.text = GameScore.wins.ToString() + "人抜き!!";
    }
}
