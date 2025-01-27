using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //Limite para que o objeto não saia da tela
        if (transform.position.x < -3)
        {
            //Limite na (ESQUERDA)
            transform.position = (new Vector2(-2f, transform.position.y));

        }

        if (transform.position.x > 3)
        {
            //Limite na (DIREITA)
            transform.position = (new Vector2(2f, transform.position.y));
        }

        if (transform.position.y > 5) {

            //Limite em (CIMA)
            transform.position = new Vector2(transform.position.x, 4.8f);

        }

        if (transform.position.y < -4.5f)
        {
            //Limite em (BAIXO)
            transform.position = new Vector2(transform.position.x, -3.8f);
        }
	}
}
