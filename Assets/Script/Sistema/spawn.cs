using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject UTUT;
    public GameObject spawnPoint;
    public GameObject spawnPointUp;
    public GameObject spawnPointDown;
    public float contadorTempo;
    //public float contadorTempo2;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
       // int tipodehorda = Random.Range(0, 2);
        int position = Random.Range(0, 4);

        float batata = Random.Range(-4, 5);
        float batata1 = Random.Range(-2.5f, 2.5f);

        contadorTempo += Time.deltaTime;

        if (contadorTempo > 4)
        {
            if (position == 1)
            {
                Instantiate(UTUT, spawnPoint.transform.position, Quaternion.identity);
                contadorTempo = 0;
            }
            
            else if(position == 2)
            {
                Instantiate(UTUT, spawnPointDown.transform.position, Quaternion.identity);
                contadorTempo = 0;
            }

            else if (position == 3)
            {
                Instantiate(UTUT, spawnPointUp.transform.position, Quaternion.identity);
                contadorTempo = 0;
            }
            /* if (tipodehorda == 1)
            {
                Instantiate(UTUT);
                contadorTempo = 0;
                UTUT.transform.position = new Vector2(8, batata);
            }
            if(tipodehorda == 2)
             {
                 Instantiate(horda2);
                 contadorTempo = 0;
                 horda2.transform.position = new Vector2(8, batata1);
             }
             if (tipodehorda == 3)
             {
                 Instantiate(horda3);
                 contadorTempo = 0;
                 horda3.transform.position = new Vector2(8, batata);

             }*/

        }




    }


}


