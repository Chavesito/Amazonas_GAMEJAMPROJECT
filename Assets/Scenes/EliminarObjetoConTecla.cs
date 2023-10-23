using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetoConTecla : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Destroy(gameObject); // Destruye el objeto al presionar la tecla X
        }
    }
}