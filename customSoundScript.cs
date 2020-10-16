using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customSoundScript : MonoBehaviour
{
    public AudioClip customSound;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playSound() {
        audioSource.PlayOneShot(customSound);
    }
}
