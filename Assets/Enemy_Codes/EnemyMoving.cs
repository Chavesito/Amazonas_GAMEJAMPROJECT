using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    public float velocidad = 3.0f; // Velocidad a la que se moverán los enemigos.
    private Transform jugador; // Referencia al transform del jugador.
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (jugador != null)
        {
            MoverHaciaJugador();
        }
    }

    void MoverHaciaJugador()
    {
        Vector2 direccion = (jugador.position - transform.position).normalized;
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
        rb.velocity = direccion;
    }
}
