using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerController : MonoBehaviour
{
	private int count;
    public float speed;
    public Text countText;
    public Text winText;
	
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText ();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
    }
	   void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
    }

    void SetCountText ()
    {
        countText.text = "Memories: " + count.ToString ();
        if (count >= 1)
        {
            winText.text = "You collected all of the items!";
        }
	}
}
