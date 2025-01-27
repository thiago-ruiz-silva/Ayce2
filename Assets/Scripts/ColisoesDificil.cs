using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisoesDificil : MonoBehaviour {

    //Para marcar os pontos
    public int pontos;
    //Para marcar o máximo
    public int maximo;
    //Para exibir a pontuação na tela (Tanto na cena do jogo quanto nas cenas finais)
    public Text pontuacao;
    //Para exibir o recorde nas telas finais
    public Text recorde;    

    // Use this for initialization
    void Start () {

        //Para pegar o valor (recordeDificil) e passar para a variável máximo
        maximo = PlayerPrefs.GetInt("recordeDificil", maximo);
       
        //Para passar o valor
        pontos = PassaDados.pontosDificil;        
    }
	
	// Update is called once per frame
	void Update () {
        
        //Para mostrar o valor na tela do jogo (Cena Jogar)
        pontuacao.text = (pontos.ToString());

        //Para mostrar o valor nas (Cenas) (Finais)
        recorde.text = (maximo.ToString());
    }

    //Para checar as colisões dos fogos com o (Chão) do (Jogo) ---E marcar a pontuação---
    private void OnCollisionEnter2D(Collision2D colisao)
    {

        //Para checar se houve uma colisão do  (Fogo) com o (Chão)
        if (colisao.gameObject.CompareTag("Fogo"))
        {

            //Para aumentar os pontos
            pontos++;

            //Para checar se pontos é maior que máximo
            if (pontos > maximo)
            {
                //Para passar o valor (isRecorde) para o script (ColisaoGelo)
                PassaDados.isRecorde = true;

                //Para passar o valor dos pontos para o máximo
                maximo = pontos;

                //Para *escrever* no banco de dados o valor de (recordeDificil)
                PlayerPrefs.SetInt("recordeDificil", maximo);

                PassaDados.maximoDificil = maximo;

                PassaDados.pontosDificil = pontos;
              
                //Para quando o (Jogador) não tiver superado o (Recorde)
            } else
            {
                PassaDados.pontosDificil = pontos;
            }            
        }
    }
}
