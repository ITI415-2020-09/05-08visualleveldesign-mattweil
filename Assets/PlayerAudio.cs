using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour {

    public AudioClip splashSound;
    public AudioSource audioS;


    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Water")){
            audioS.PlayOneShot(splashSound);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
