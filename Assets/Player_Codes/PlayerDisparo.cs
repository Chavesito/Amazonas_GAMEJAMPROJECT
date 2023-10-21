using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisparo : MonoBehaviour
{
    [SerializeField] private Transform ContenedorDisparo;
    [SerializeField] private GameObject bala;
    void Update()
    {
        ApuntarConRaton();

        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    private void ApuntarConRaton()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        ContenedorDisparo.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }


    private void Disparar()
    {
        Instantiate(bala, ContenedorDisparo.position, ContenedorDisparo.rotation);
    }
}