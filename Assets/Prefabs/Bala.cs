using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int cantidadDeDaño = 100;
    public float velocidad = 10f;

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

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.tag);
        /*if (other.CompareTag("Enemy"))
        {
            //Enemy enemy = other.GetComponent<Enemy>();
            Destroy(gameObject);
        }*/
    }
}
