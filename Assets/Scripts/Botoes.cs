using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour {

    //Para poder mostrar e não mostrar as mensagens ---Na (Cena) (Mensagem)---
    public GameObject mensagemDoacao, mensagemPix, mensagemPayPal;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Para chamar a cena (Jogar)
    public void Facil()
    {        
        //Para chamar a (Cena) Jogar
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogar");

        //Para escolher o modo (Fácil)
        PassaDados.escolha = 1;
    }

    //Para chamar a cena (Jogar)
    public void Dificil()
    {        
        //Para chamar a (Cena) Jogar
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogar");

        //Para escolher o modo (Difícil)
        PassaDados.escolha = 2;
    }

    //Para chamar a cena (Start) ---voltar para a tela inicial---
    public void Voltar()
    {
        //Para chamar a (Cena) Start || (Cena) inicial do (Jogo)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");

        //Para (Zerar) essas variáveis
        PassaDados.pontosDificil = 0;
        PassaDados.pontosFacil = 0;
    }

    //Para chamar a (Cena) Mensagem
    public void Doar()
    {
        //Para chamar a (Cena) de (Doação)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Mensagem");
    }

    //Para copiar a (Chave) (Pix) de doação do (Jogo)
    public void CopiarChavePix()
    {
        //Para copiar a (Chave) (Pix)
        GUIUtility.systemCopyBuffer = "thiagoruiz.y2@gmail.com";

        //Para que a mensagem (Doação) desapareça depois que o (Botão) (Copiar Chave Pix) for pressionado
        mensagemDoacao.SetActive(false);
        //Para mostrar a (Mensagem) (Chave Pix copiada com sucesso) depois que o (Botão) (Copiar Chave Pix) for pressionado
        mensagemPix.SetActive(true);

        //Para que não apareça a mensagem do (PayPal)
        mensagemPayPal.SetActive(false);
    }

    //Para copiar o (Email) de doação do (PayPal)
    public void CopiarEmailPayPal()
    {
        //Para copiar o (Email de doação do PayPal)
        GUIUtility.systemCopyBuffer = "thiagoruiz.y2@gmail.com";

        //Para que a mensagem (Doação) desapareça depois que o (Botão) (PayPal Donation) for pressionado
        mensagemDoacao.SetActive(false);

        //Para mostrar a (Mensagem) (Email Copiado Com Sucesso) depois que o (Botão) (PayPal Donation) for pressionado
        mensagemPayPal.SetActive(true);

        //Para que não apareça a mensagem do (Pix)
        mensagemPix.SetActive(false);
    }
}
