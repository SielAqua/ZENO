using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(9 * Vector2.left * Time.deltaTime);


        if (transform.position.x < -52.0f)
        {
            gameObject.transform.position = new Vector2(26f, gameObject.transform.position.y);
        }

    }
}
