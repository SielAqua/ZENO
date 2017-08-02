using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentacaoInimigo : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(8.5f * Vector2.left * Time.deltaTime);

        if (Camera.main.WorldToViewportPoint(this.transform.position).x < 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(player);
            SceneManager.LoadScene("GameOver");
        }


    }
}
