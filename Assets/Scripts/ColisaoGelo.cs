using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoGelo : MonoBehaviour {

    //Para usar a animação
    public Animator animacao;
    //Para usar o som
    public GameObject som;
    //Para esperar um certo tempo para que a animação do gelo deretendo possa rodar até o final e depois a nova cena será chamada
    public float tempoFinal;
    //Variavel bool
    bool isFinal;

	void Start () {
        //Para destruir os fogos na tela depois que um dos fogos atingir o gelo
        PassaDados.isJogando = true;

        isFinal = false;
       
        PassaDados.isRecorde = false;
    }
	
	// Update is called once per frame
	void Update () {

        //Para começar a contar o tempo depois da colisão de um dos fogos com o gelo
        if (isFinal == true)
        {
            //Para diminuir o tempo até que ele chegue a (0) para chamar a outra cena
            tempoFinal -= Time.deltaTime;
        }
        //Para checar qual escolha foi feita (ver script * PassaDados *)
        if (tempoFinal <= 0 && PassaDados.escolha == 1)
        {
            //Para chamar a cena de recorde (caso o jogador tenha batido o recorde)
            if (PassaDados.isRecorde == true)
            {
                //Chama a cena (RecordeFacil)
                UnityEngine.SceneManagement.SceneManager.LoadScene("RecordeFacil");
            }else
            {
                //Chama a cena (FimFacil)
                UnityEngine.SceneManagement.SceneManager.LoadScene("FimFacil");
            }            
        } 
        //Para checar qual escolha foi feita (ver script * PassaDados *)
        if (tempoFinal <= 0 && PassaDados.escolha == 2)
        {
            //Para chamar a cena de recorde (caso o jogador tenha batido o recorde)
            if (PassaDados.isRecorde == true)
            {
                //Para chamar a cena (RecordeDificil)
                UnityEngine.SceneManagement.SceneManager.LoadScene("RecordeDificil");
            }else
            {
                //Para chamar a cena (FimDificil)
                UnityEngine.SceneManagement.SceneManager.LoadScene("FimDificil");
            }            
        }
	}
    //Para checar a colisão com o gelo
    private void OnCollisionEnter2D(Collision2D colisao)
    {
        //Para se o gelo colidir com o fogo
        if (colisao.gameObject.CompareTag("Fogo"))
        {
            //Para destruir todos os fogos da tela (ver script * DestroiFogo *)
            PassaDados.isJogando = false;

            //Para parar o música do jogo
            GetComponent<AudioSource>().Stop();

            //Para rodar a animação do gelo deretendo
            animacao.Play("GeloDeretendo");

            //Para tocar o som de "derota" 
            Instantiate(som, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
            
            //Para começar a contagem regressiva (ver primeira para do método Update desse script)
            isFinal = true;
        }
    }
}
