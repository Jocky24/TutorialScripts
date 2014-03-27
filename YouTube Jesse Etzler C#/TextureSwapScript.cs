using UnityEngine;
using System.Collections;

public class TextureSwapScript : MonoBehaviour 
{
	public Texture2D texture1;
	public Texture2D texture2;

	bool swap = true;
	
	void Start () 
	{
		StartCoroutine ("textureSwap", 0.5);
	}

	IEnumerator textureSwap (float swapAfter)
	{
		int i;
		for (i = 1; i > 0; i++)
		{
			if (swap == true) 
			{
				renderer.material.mainTexture = texture1;
				swap = false;
				yield return new WaitForSeconds (swapAfter);
			} 
			if (swap == false) 
			{
				renderer.material.mainTexture = texture2;
				swap = true;
				yield return new WaitForSeconds (swapAfter);
			}
		}
	}
}
