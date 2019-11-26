using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateScript : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Walking",true);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);

        }
        /*  if (Input.GetKeyDown(KeyCode.K))
          {
              animator.SetTrigger("Kick");
          }
          if (Input.GetKeyDown(KeyCode.W))
          {
              animator.SetTrigger("Walk");
          } */
    }
}
