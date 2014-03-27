using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour 
{
	public bool paused = false;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.P) && paused == false) 
		{
			paused = true;
			Time.timeScale = 0.0f;
		} 
		else if (Input.GetKeyDown (KeyCode.P) && paused == true) 
		{
			paused = false;
			Time.timeScale = 1.0f;
		}
	}
}
