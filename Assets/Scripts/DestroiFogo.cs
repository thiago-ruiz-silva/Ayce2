using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiFogo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //Para destruir todos os fogos após a colisão de um dos fogos com o gelo 
        //(Ver Script) (ColisaoGelo) 
        if (PassaDados.isJogando == false)
        {
            Destroy(this.gameObject);
        }
	}
}
