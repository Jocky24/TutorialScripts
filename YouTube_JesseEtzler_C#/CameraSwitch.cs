using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour 
{	
	public GameObject camera1;
	public GameObject camera2;
	
	void Start () 
	{
		camera1.SetActive (true);
		camera2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.K)) 
		{
			camera2.SetActive (false);
			camera1.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.L)) 
		{
			camera1.SetActive (false);
			camera2.SetActive (true);
		}
	}
}
