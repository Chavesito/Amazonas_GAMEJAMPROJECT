using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public GameObject Player;
    private Vector3 posicionRelativa;

// Use this for initialization
    void Start () {

        posicionRelativa = transform.position - Player.transform.position;

    }

// Update is called once per frame
    void Update () {

        transform.position = Player.transform.position + posicionRelativa;

    }

}
