using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fogos : MonoBehaviour {


    //Esse script é para criar os fogo na tela
    public GameObject fogo1;
    public GameObject fogo2;

    public int contador1;
    public int contador2;
    public int contador3;
    public int contador4;
    public int contador5;

    //Variável fator para que os fogos caiam mais pertos uns do outros
    //Para que a distância entre os fogos seja menor
    public int fator;

    //Variável (posicao1) para que os fogos não caiam muito longe uns do outros
    //Para que a frequência de queda dos fogos seja (Melhor)
    public int posicao1;

    //Para determinar a distância (Em "X") dos fogos || Que deverá ser definida no (Unity)
    public float[] posicoes;  

    void Start () 
    {      
        
        
    }
	
	// Update is called once per frame
	void Update () {

        //Ver (Script) (Fogos2)
        if (contador1 == 0)
        {
            Instantiate(fogo1, new Vector2(posicoes[0], posicao1), Quaternion.identity);

            posicao1++;

            contador1 = 120;
        }

        if (contador2 == 0)
        {
            Instantiate(fogo2, new Vector2(posicoes[1], posicao1), Quaternion.identity);

            contador2 = 140 - fator;
        }

        if (contador3 == 0)
        {

            Instantiate(fogo2, new Vector2(posicoes[2], posicao1), Quaternion.identity);

            contador3 = 140 - fator;
        }

        if (contador4 == 0)
        {

            Instantiate(fogo1, new Vector2(posicoes[3], posicao1), Quaternion.identity);

            contador4 = 140 - fator;
        }

        if (contador5 == 0)
        {

            Instantiate(fogo2, new Vector2(posicoes[4], posicao1), Quaternion.identity);

            contador5 = 140 - fator;

            fator += 10;
        }

        contador1--;
        contador2--;
        contador3--;
        contador4--;
        contador5--;                
    }
}
