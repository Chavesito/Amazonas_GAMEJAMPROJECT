using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int cantidadDeDaño = 10;
    public float velocidad = 2f;
    public float intensidad = 1.0f;

    void Start(){
        Destroy(gameObject, 1);
    }
    void Update()
    {
        Mover();
    }

    void Mover()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime*intensidad);
    }
     public void ModificarIntensidad(float nuevaIntensidad)
    {
        intensidad = nuevaIntensidad;
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
