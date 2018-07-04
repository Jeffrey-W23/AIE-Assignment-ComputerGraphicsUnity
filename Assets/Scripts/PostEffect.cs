// using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// PostEffect object. Inheriting from MonoBehaviour. Apple a post effect to the camera
//--------------------------------------------------------------------------------------
public class PostEffect : MonoBehaviour
{
    // public material value for the post effect material.
    public Material material;

    //--------------------------------------------------------------------------------------
    // OnRenderImage: OnRenderImage is called after all rendering is complete to render image.
    //--------------------------------------------------------------------------------------
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Color[] pixels = new Color[1920 * 1080];
        Graphics.Blit(source, destination, material);
    }
}
