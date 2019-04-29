using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip recordingClip;

    public AudioSource recordingSource; 
    // Start is called before the first frame update
    void Start()
    {
        recordingSource.clip = recordingClip; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            recordingSource.Play(); 
        }
    }
}
