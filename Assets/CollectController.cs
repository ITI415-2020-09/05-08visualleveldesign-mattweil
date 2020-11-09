using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectController : MonoBehaviour
{
    private int count;
	private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();

        count = 0;
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


		}
	}
}
