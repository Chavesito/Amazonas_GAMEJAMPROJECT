using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rb;
    [Range(1, 20)] public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");       
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal*velocidad, movimientoVertical*velocidad);

        rb.velocity = movimiento;
    }      
}
