// using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;

//--------------------------------------------------------------------------------------
// MainUI object. Inheriting from MonoBehaviour. The main script for the UI.
//--------------------------------------------------------------------------------------
public class MainUI : MonoBehaviour 
{
    // public particle system for particle 2
    public ParticleSystem ps1;

    // public particle system for particle 1
    public ParticleSystem ps2;

    // public camera for the main camera in the scene
    public Camera camera;


    //--------------------------------------------------------------------------------------
    // initialization.
    //--------------------------------------------------------------------------------------
    void Awake ()
    {
    }

    //--------------------------------------------------------------------------------------
    // Update: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void Update () 
    {
	}

    //--------------------------------------------------------------------------------------
    // ParticleButton1Click: Function that plays a particle when a button is pressed
    //--------------------------------------------------------------------------------------
    public void ParticleButton1Click()
    {
        // if particle is playing
        if (ps1.isPlaying)
        {
            // stop particle
            ps1.Stop();
        }
        else
        {
            // play particle
            ps1.Play();
        }
    }

    //--------------------------------------------------------------------------------------
    // ParticleButton2Click: Function that plays a particle when a button is pressed
    //--------------------------------------------------------------------------------------
    public void ParticleButton2Click()
	{
        // if particle is playing
		if (ps2.isPlaying)
		{
            // stop partice
			ps2.Stop();
		}
		else
		{
            // play particle
			ps2.Play();
		}
	}

    //--------------------------------------------------------------------------------------
    // PostProcessingToggle: Function that toggles camera post processing off and on
    //--------------------------------------------------------------------------------------
    public void PostProcessingToggle()
    {
        // if the post processing is enabled
        if (camera.GetComponent<PostProcessingBehaviour>().GetComponentInChildren<PostProcessingBehaviour>().enabled)
        {
            // turn off post processing
            camera.GetComponent<PostProcessingBehaviour>().GetComponentInChildren<PostProcessingBehaviour>().enabled = false;
        }
        else
        {
            // turn post processing back on.
            camera.GetComponent<PostProcessingBehaviour>().GetComponentInChildren<PostProcessingBehaviour>().enabled = true;    
        }
    }
}
