//Attach this script to a GameObject
//Create an Image GameObject by going to Create>UI>Image. Attach this Image to the Image field in your GameObject’s Inspector window.
//This script creates a toggle that fades an Image in and out.
using UnityEngine;
using UnityEngine.UI;

public class ImageFadeIn : MonoBehaviour
{
    //Attach an Image you want to fade in the GameObject's Inspector
    public Image m_Image;
	
	void Update()
	{
	    var tempColor = m_Image.color;
        tempColor.a = 0f; //1f makes it fully visible, 0f makes it fully transparent.
        m_Image.color = tempColor;
		m_Image.CrossFadeAlpha(1, 2.0f, false);
	}
}