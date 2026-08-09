using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour
{
	private SpriteRenderer limeonadeSprite;
	public Sprite defaultImage;
	public Sprite pressedImage;
	
	public KeyCode keyToPress;
	
	void Start () 
	{
		limeonadeSprite = GetComponent<SpriteRenderer>();
	}
	
	void Update () 
	{
		if(Input.GetKeyDown(keyToPress))
		{
			limeonadeSprite.sprite = pressedImage;
		}
		
		if(Input.GetKeyUp(keyToPress))
		{
			limeonadeSprite.sprite = defaultImage;
		}
		
	}
	
    void buttonClick()
    {
        Debug.Log("button pressed :3");
    }
}
