using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    private PlayerDisparo playerDisparo;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerDisparo = GetComponent<PlayerDisparo>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") && !playerDisparo.cargandoDisparo){
            animator.SetBool("Movimiento",true);
            animator.SetInteger("DIRECCION",8);
        }
        else if(Input.GetKey("s") && !playerDisparo.cargandoDisparo){
            animator.SetBool("Movimiento",true);
            animator.SetInteger("DIRECCION",2);
        
        }
       else if(Input.GetKey("a") && !playerDisparo.cargandoDisparo){
            animator.SetBool("Movimiento",true);
            animator.SetInteger("DIRECCION",4);
        }
        else if(Input.GetKey("d") && !playerDisparo.cargandoDisparo){
            animator.SetBool("Movimiento",true);
            animator.SetInteger("DIRECCION",6);
        
        
        }else{
            animator.SetBool("Movimiento",false);
        }
        
     }
        
}
