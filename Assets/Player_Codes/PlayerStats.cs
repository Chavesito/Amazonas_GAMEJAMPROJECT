using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
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
    }

}