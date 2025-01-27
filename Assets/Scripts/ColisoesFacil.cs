using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisoesFacil : MonoBehaviour {


    //VER SCRIPT (ColisoesDificil) ***

    public int pontos;

    public int maximo;

    public Text pontuacao;

    public Text recorde;   

    // Use this for initialization
    void Start () {
        
        maximo = PlayerPrefs.GetInt("recordeFacil", maximo);        

        pontos = PassaDados.pontosFacil;        
    }
	
	// Update is called once per frame
	void Update () {

        pontuacao.text = (pontos.ToString());

        recorde.text = (maximo.ToString());
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Fogo"))
        {
            pontos = pontos + 1;

            if (pontos > maximo)
            {
                PassaDados.isRecorde = true;

                maximo = pontos;

                PlayerPrefs.SetInt("recordeFacil", maximo);

                PassaDados.maximoFacil = maximo;

                PassaDados.pontosFacil = pontos;
            }
            else
            {
                PassaDados.pontosFacil = pontos;                
            }            
        }
    }
}
