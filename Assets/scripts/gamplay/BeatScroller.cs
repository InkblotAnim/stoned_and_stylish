using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{

    public float beatTempo;

    public bool hasStarted;

    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
         /*   if(Input.anyKeyDown)
            {
                hasStarted = true;
            } */
        } 
		else
            {
                transform.position += new Vector3(beatTempo * Time.deltaTime, 0f, 0f);
            }
    }
}

// ngl I just been following a tutorial but now I've gotten enough done to where I needa lock tf in and
// actually make this mostly myself

// also you'll prolly find the tutorial I used easily because 
// HOLY SHIT THERE ARE NO TUTORIALS ABOUT ANYTHING RELATED TO RHYTHM GAMES!!! LIKE WHAAAAT???