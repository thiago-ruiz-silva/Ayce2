using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaDados : MonoBehaviour {

    //Esse script é para poder passar os dados de um script para outro

    //Para escolher entre os dois tipos de jogo (Fácil ou Difícil)
    public static int escolha;
    

    //Para passar os valores 
    public static int pontosFacil;
    public static int maximoFacil;

    //Para (Zerar) essas variáveis quando for apertado o botão (Voltar)
    public static int pontosDificil;
    public static int maximoDificil;

    //Para destruir todos os fogos que estão na tela (ver script * ColisoesGelo * & * DestroiFogo *)
    public static bool isJogando;

    //Para que se o recorde for batido essa variável se torna * true * (ver script * ColisaoGelo *)
    public static bool isRecorde;

	// Use this for initialization
	void Start () {

        isRecorde = false;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
