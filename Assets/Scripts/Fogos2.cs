using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fogos2 : MonoBehaviour {

    //Esse script é para criar os fogo na tela
    public GameObject fogo1;
    public GameObject fogo2;

    public int contador1;
    public int contador2;
    public int contador3;
    public int contador4;
    public int contador5;

    //Variável (sorteio) para que os fogos sejam criados aleatoriamente
    int sorteio;

    //Variável (posicao1) para que os fogos não caiam muito longe uns do outros
    //Para que a frequência de queda dos fogos seja (Melhor)
    public int posicao1;

    //Para determinar a distância (Em "X") dos fogos || Que deverá ser definida no (Unity)
    public float[] posicoes;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Para sortear e fazer com que os fogos sejam (Totalmente) aleatórios
        sorteio = Random.Range(0, 2);

        if (sorteio == 0)
        {

            if (contador1 == 0)
            {
                //Para criar o (Fogo)
                Instantiate(fogo1, new Vector2(posicoes[0], posicao1), Quaternion.identity);

                posicao1++;

                contador1 = 150;
            }

            //Mesmo funcionamento acima
            if (contador2 == 0)
            {

                Instantiate(fogo2, new Vector2(posicoes[1], posicao1), Quaternion.identity);

                contador2 = 150;
            }

            if (contador3 == 0)
            {

                Instantiate(fogo2, new Vector2(posicoes[2], posicao1), Quaternion.identity);

                contador3 = 150;
            }

            if (contador4 == 0)
            {

                Instantiate(fogo1, new Vector2(posicoes[3], posicao1), Quaternion.identity);

                contador4 = 150;
            }

            if (contador5 == 0)
            {

                Instantiate(fogo2, new Vector2(posicoes[4], posicao1), Quaternion.identity);

                contador5 = 130;                
            }
        }

        if (sorteio == 1)
        {

            if (contador1 == 0)
            {

                Instantiate(fogo1, new Vector2(posicoes[4], posicao1), Quaternion.identity);

                posicao1++;

                contador1 = 150;
            }

            if (contador2 == 0)
            {

                Instantiate(fogo2, new Vector2(posicoes[3], posicao1), Quaternion.identity);

                contador2 = 150;
            }

            if (contador3 == 0)
            {

                Instantiate(fogo2, new Vector2(posicoes[2], posicao1), Quaternion.identity);

                contador3 = 150;
            }

            if (contador4 == 0)
            {

                Instantiate(fogo1, new Vector2(posicoes[1], posicao1), Quaternion.identity);

                contador4 = 150;
            }

            if (contador5 == 0)
            {

                Instantiate(fogo2, new Vector2(posicoes[0], posicao1), Quaternion.identity);

                contador5 = 130;              
            }
        }
        contador1--;
        contador2--;
        contador3--;
        contador4--;
        contador5--;
    }
}
