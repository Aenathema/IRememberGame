using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour 
{
	public Button Pause_Button;
	public Button Resume_Button;
	
    void Start()
    {
		Pause_Button.onClick.AddListener(TaskOnClick);
		Resume_Button.onClick.AddListener(TaskOnClick);
		Time.timeScale = 1;
    }	
	void TaskOnClick()
	{
         if (Time.timeScale == 1)
         	{
             Time.timeScale = 0;
         	}
         else
         	{
             Time.timeScale = 1;
        	}
	}
 }