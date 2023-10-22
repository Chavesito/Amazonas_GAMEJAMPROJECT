using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisparo : MonoBehaviour
{
    [SerializeField] private Transform ContenedorDisparo;
    [SerializeField] private GameObject bala;
    [SerializeField] private GameObject puñete;
    private bool golpeando;
    private float tiempoCarga = 0.0f;
    public bool cargandoDisparo=false; // Nueva variable para rastrear si se está cargando un disparo
    public float tiempoMaxCarga = 2.0f; // Tiempo máximo de carga

    void Update()
    {
        ApuntarConRaton();

        
            if (Input.GetButtonDown("Fire1"))
            {
                tiempoCarga = 0.0f; // Reiniciar tiempo de carga
                cargandoDisparo = true; // Inicia la carga del disparo
            }
            else if (Input.GetButton("Fire1") && tiempoCarga < tiempoMaxCarga)
            {
                tiempoCarga += Time.deltaTime;
            }
            else if (Input.GetButtonUp("Fire1") && !golpeando)
            {
                Disparar(tiempoCarga / tiempoMaxCarga); // Pasa el valor normalizado de la carga
                cargandoDisparo = false; // Finaliza la carga del disparo
            }
            else if (Input.GetButtonDown("Fire2"))
            {
                if (!golpeando)
                {
                    StartCoroutine(Atacar());
                }
            }
        
    }

    private void ApuntarConRaton()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        ContenedorDisparo.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }


  private void Disparar(float intensidad)
    {
        // Usar 'intensidad' para modificar el comportamiento del disparo (velocidad, daño, etc.)
        GameObject nuevaBala = Instantiate(bala, ContenedorDisparo.position, ContenedorDisparo.rotation);
        nuevaBala.GetComponent<Bala>().ModificarIntensidad(intensidad); // Asignar intensidad a la bala
    }

    private IEnumerator Atacar()
    {
        golpeando = true;

        GameObject newGolpe = Instantiate(puñete, ContenedorDisparo.position, ContenedorDisparo.rotation);
        yield return new WaitForSeconds(0.3f);
        Destroy(newGolpe);
        golpeando = false;
    }
}