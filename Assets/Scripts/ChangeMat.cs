using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    public Material mat; // this is the mat you want the hands changed to.


    private GameObject handLeft;
    private GameObject handRight;

    //
    void Update()
    {
        // find and grab the hand objects
        handRight = GameObject.Find("hand_right");
        handLeft = GameObject.Find("hand_left");

        // if i've found the hands change the texture
        if (handRight != null && handLeft != null)
        {
            handLeft.GetComponent<Renderer>().material = mat;
            handRight.GetComponent<Renderer>().material = mat;
        }
    }
}
