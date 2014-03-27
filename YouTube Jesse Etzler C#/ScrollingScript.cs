using UnityEngine;
using System.Collections;

public class ScrollingScript : MonoBehaviour 
{
	public float scrollSpeed = 0.9f;
	public float scrollSpeed2 = 0.9f;

	// Update is called once per frame
	void FixedUpdate () 
	{
		float offset = Time.time * scrollSpeed;
		float offset2 = Time.time * scrollSpeed2;

		renderer.material.mainTextureOffset = new Vector2 (offset2, - offset);
	}
}
