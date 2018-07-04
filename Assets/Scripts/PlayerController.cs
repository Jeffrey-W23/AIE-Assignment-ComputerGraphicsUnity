// using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// Player object. Inheriting from MonoBehaviour. The main player class for player movement
//--------------------------------------------------------------------------------------
public class PlayerController : MonoBehaviour 
{
    // public Animator for main animator of the player
    public Animator anim;

    //--------------------------------------------------------------------------------------
    // initialization.
    //--------------------------------------------------------------------------------------
    void Awake () 
    {
        // get the animation component
        anim = GetComponent<Animator>();
	}

    //--------------------------------------------------------------------------------------
    // Update: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void Update () 
    {
        // if the w key is pressed play an animation
        if (Input.GetKey(KeyCode.W))
        {
            // play animation
            anim.SetBool("isWalking", true);
        }
        else
        {
            // stop animation
            anim.SetBool("isWalking", false);
        }

        // if the w key is pressed play with the shift key play an animation
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
		{
            // play animation
            anim.SetBool("isRunning", true);
		}
		else
		{
            // stop animation
            anim.SetBool("isRunning", false);
		}
	}
}