using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    
    //Animator references.
    public Animator cubeAnimator;
    public Animator triggerAnimator;
    public Animator floatAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
                   
    }

    // Update is called once per frame
    void Update()
    {
        //If and else if statements for the rotating cube that start and stop once tab is pressed.
        if (Input.GetKeyDown(KeyCode.Tab) && cubeAnimator.GetBool("Rotate") == false)
        {
            cubeAnimator.SetBool("Rotate", true);
        }
        else if(Input.GetKeyDown(KeyCode.Tab) && cubeAnimator.GetBool("Rotate") == true)
        {
            cubeAnimator.SetBool("Rotate", false);
        } 
        
    }
}
