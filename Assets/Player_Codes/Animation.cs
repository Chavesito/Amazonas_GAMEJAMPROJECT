using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("a")){
            animator.SetBool("Movimiento",true);
            animator.SetInteger("DIRECCION",4);
        }
        else if(Input.GetKey("d")){
            animator.SetBool("Movimiento",true);
            animator.SetInteger("DIRECCION",6);
        }
        else if (Input.GetKey("w")){
            animator.SetBool("Movimiento",true);;
            animator.SetInteger("DIRECCION",8);
        }
        else if(Input.GetKey("s")){
            animator.SetBool("Movimiento",true);
            animator.SetInteger("DIRECCION",2);
        }else{
            animator.SetBool("Movimiento",false);
        }
        
        
    }
}
