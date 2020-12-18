using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public AnimationClip clip;
    public AnimationClip clip2;
    public Animation animation;
    public GameObject ventel;
    public bool isOpen = false;
    public void DoAnimation()
    {
        if (isOpen == false)
        {
            ventel.GetComponent<Animation>().Play(clip2.name);
            isOpen = true;
        }
        else
        {
            isOpen = false;
            ventel.GetComponent<Animation>().Play(clip.name);
        }
    }
  
}
