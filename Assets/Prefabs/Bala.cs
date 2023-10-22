using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int cantidadDeDaño = 10;
    public float velocidad = 2f;

    void Start(){
        Destroy(gameObject, 1);
    }
    void Update()
    {
        Mover();
    }

    void Mover()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    ///void OnTriggerEnter2D(Collider2D other)
    //{
      // if (other.CompareTag("Enemy"))
        //{
          //  EnemyStats enemigo = other.GetComponent<EnemyStats>();

            //if (enemigo != null)
           // {
                //enemigo.RecibirDaño(cantidadDeDaño);
              //  Destroy(gameObject);
            //}
        //}
    //}
}
