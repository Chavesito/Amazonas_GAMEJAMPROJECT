using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int VidaMaxima=100;
    private int Vida;
    // Start is called before the first frame update
    void Start()
    {
        Vida = VidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void RecibirDaño(int daño)
    {
        

        Vida = Vida - daño;
        if (Vida <= 0){
            Morir();
        }

        Debug.Log(Vida);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
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