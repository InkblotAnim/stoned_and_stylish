using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatObject : MonoBehaviour
{
	
	public bool canBePressed;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(keyToPress)){};
    }
	
	private void onTriggerEnter2d(Collider2D other)
	{
		if(other.tag == "Activator")
		{
			canBePressed = true;
		}
	}
	private void onTriggerExit2d(Collider2D other)
	{
		if(other.tag == "Activator")
		{
			canBePressed = false;
		}
	}
}
