using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escolha : MonoBehaviour {

    //Para escolher entre as saídas e chão
    //Para que os objetos (Fogos) caiam de uma forma diferente de acordo com a escolha na tela inicial  ---Analizar---
    public GameObject saida1;
    public GameObject saida2;
    public GameObject chao1;
    public GameObject chao2;
	// Use this for initialization
	void Start () {
		
        if (PassaDados.escolha == 1)
        {
            saida1.SetActive(true);
            saida2.SetActive(false);
            chao1.SetActive(true);
            chao2.SetActive(false);
        }

        if (PassaDados.escolha == 2)
        {
            saida1.SetActive(false);
            saida2.SetActive(true);
            chao1.SetActive(false);
            chao2.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
