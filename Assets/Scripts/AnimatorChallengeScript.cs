using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    
    //Animator reference.
    public Animator cubeAnimator;
    public Animator triggerAnimator;
    public Animator floatAnimator;
    //Bool for the jump.
    bool m_Spin;

    // Start is called before the first frame update
    void Start()
    {
        
                    
    }

    // Update is called once per frame
    void Update()
    {
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
