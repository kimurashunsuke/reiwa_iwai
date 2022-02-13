using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMainBgm : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    public static bool onPlayBgm = false;
    
    void Start()
    {
        if (! onPlayBgm) {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            onPlayBgm = true;
        }
        if (DontDestroyEnabled) {
            // Sceneを遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad (this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
