using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private int count;
	
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
	 void OnTriggerEnter(Collider other) 
    {
		if (other.gameObject.CompareTag ("Pick Up"))
		{
		other.gameObject.SetActive (false);
		count = count + 1;
		}
	}
	}
}