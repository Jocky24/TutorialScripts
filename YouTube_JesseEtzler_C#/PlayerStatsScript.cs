using UnityEngine;
using System.Collections;

public class PlayerStatsScript : MonoBehaviour 
{
	public int curHealth = 100;
	public int maxHealth = 100;
	public int curXp = 0;
	public int maxXp = 200;
	public int level = 1;
	public int hpMinus = 10;
	public int xpAdd = 10;

	public GUIText healthText;
	public GUIText xpText;
	
	void Start () 
	{
		StartCoroutine ("HealthRegen", 0.5);
	}
	
	// Update is called once per frame
	void Update () 
	{
		healthText.text = curHealth + " / " + maxHealth;
		xpText.text = "LV " + level + " XP " + curXp + " / " + maxXp;

		if (curHealth < 0)
			curHealth = 0;
		if (curHealth > maxHealth)
			curHealth = maxHealth;
		if (curXp >= maxXp)
			LevelUpSystem ();

		if (Input.GetKeyDown (KeyCode.E))
			curHealth -= hpMinus;
		if (Input.GetKeyDown (KeyCode.R))
			curXp += xpAdd;
	}

	IEnumerator HealthRegen (float timeWait)
	{
		int i;
		for (i = 1; i > 0; i++)
		{
			if (curHealth < maxHealth)
				curHealth++;
				
			yield return new WaitForSeconds (timeWait);
		}
	}

	void LevelUpSystem ()
	{
		curXp = 0;
		maxXp *= 2;
		level++;
		maxHealth = (int)(maxHealth * 1.5);
	}
}
