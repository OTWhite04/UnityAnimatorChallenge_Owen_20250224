using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorChallengeScript : MonoBehaviour
{
    
    //Animator reference.
    Animator m_Animator;
    //Bool for the jump.
    bool m_Spin;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        m_Spin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && m_Animator.GetBool("Spin") == false)
        {
            m_Animator.SetBool("Cube_AnimController", true);
        }
        else 
        {
            m_Animator.SetBool("Cube_AnimController", false);

        } 
        
    }
}
