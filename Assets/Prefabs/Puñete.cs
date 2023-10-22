using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puñete : MonoBehaviour
{
    public int cantidadDeDaño = 100;

    void Start(){
        Destroy(gameObject, 1);
    }
    void Update()
    {
        Mover();
    }

    void Mover()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.CompareTag("Enemy"))
        {
            //Enemy enemy = other.GetComponent<Enemy>();
            Destroy(gameObject);
        }*/
    }
}
