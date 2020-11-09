using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectController : MonoBehaviour
{

	// public AudioClip pickupSound;
	public AudioSource audioSource;
	public Text score;
	public Text timeText;

    private int count;
	private Rigidbody rb;
 	public static float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		score = GameObject.FindGameObjectWithTag("UI").GetComponent<Text>();
		audioSource = GameObject.FindGameObjectWithTag("AS").GetComponent<AudioSource>();
		score.text = "Orbs Collected: 0";
		timeText = GameObject.FindGameObjectWithTag("Timer").GetComponent<Text>();
        count = 0;
    }


	     

 void Update ()
  {

		timer += Time.deltaTime;



		float minutes = Mathf.Floor(timer / 60);
 		float seconds = Mathf.RoundToInt(timer%60);

		if(seconds < 10){
			timeText.text =  minutes + ":0" + seconds;
		} else {
			timeText.text =  minutes + ":" + seconds;
		}

   
 }

	void OnTriggerEnter(Collider other) 
	{
		print("TEST0");
		// ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("Collectable"))
		{
			other.gameObject.SetActive (false);
			
			// Add one to the score variable 'count'
			count = count + 1;
			AudioClip audioClip = Resources.Load("./powerup/powerup_3.wav") as AudioClip;
			audioSource.PlayOneShot(audioClip);
			score.text = "Orbs Collected: " + count.ToString();



		}
	}
}
