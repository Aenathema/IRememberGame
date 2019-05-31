using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Collect : MonoBehaviour
{
	public AudioSource audioClip;

	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D()
	{
    	transform.gameObject.SetActive(false);
        audioClip.Play();
	}
}
