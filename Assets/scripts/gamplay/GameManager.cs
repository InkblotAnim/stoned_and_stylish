using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	
	public AudioSource theMusic;
	
	public bool startPlaying;
	
	public BeatScroller bullshit;
	
	
	
    void Start()
    {
        
    }


    void Update()
    {
        if(!startPlaying) 
		{
			if(Input.anyKeyDown) 
			{
				 startPlaying = true;
				 bullshit.hasStarted = true;
				 
				 theMusic.Play();
			}
		}
    }
}
