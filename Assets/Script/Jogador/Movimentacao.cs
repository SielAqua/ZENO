using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    public Vector2 direcao;
    public float vel = 0.5f;

    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(direcao * vel);
            direcao = Vector2.up;
        }


        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(direcao * vel);
            direcao = Vector2.down;

        }

        
    }
}
    



