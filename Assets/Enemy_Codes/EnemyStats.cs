using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    
    private int Vida;
    // Start is called before the first frame update
    void Start()
    {
        Vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

public void RecibirDaño(int daño)
    {
        

        Vida -= daño;
        if (Vida <= 0){
            Morir();
        }

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.CompareTag("Bala"))
        {
            Bala bala = other.GetComponent<Bala>();

            if (bala != null){
                RecibirDaño(bala.cantidadDeDaño);

                Destroy(other.gameObject);
            }

            
        }
    }

    void Morir(){
        Destroy(gameObject);
    }
}