using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour 
{

	public Text text;

	public Text wordText;
	public float fallSpeed = 4f;
	public Rigidbody2D rb;
	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
	}

	public void RemoveWord ()
	{
		Destroy(gameObject);
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
		
		if (wordText.transform.position.y <= -5f) 
        {
            Destroy(gameObject);
        }
	}


}
