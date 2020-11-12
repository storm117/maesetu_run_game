using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ProcessInput()
{
if (Input.GetKey(KeyCode.Space))
{
GetComponent<AudioSource>().Play();
audioSource.PlayOneShot(sound1);
}
}
}
