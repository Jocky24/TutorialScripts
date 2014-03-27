using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour 
{
	public Transform target1;
	public Transform target2;
	public Transform target3;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "teleport") 
		{
			int randomNumber = Random.Range (0, 3);
			Debug.Log ("The Random number chosen is " + randomNumber);

			if (randomNumber == 0)
			{
				Vector3 myTransform = target1.transform.position;
				transform.position = myTransform;
			}

			if (randomNumber == 1)
			{
				Vector3 myTransform = target2.transform.position;
				transform.position = myTransform;
			}

			if (randomNumber == 2)
			{
				Vector3 myTransform = target3.transform.position;
				transform.position = myTransform;
			}
		}
	}
}
