using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    private Touch toque;
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //(PassaDados.isJogando) para que não possa mover o (Gelo) depois que ele for (Atingido)
        if (Input.touchCount > 0 && PassaDados.isJogando)
        {

            //Para pegar o toque na tela do jogo
            toque = Input.GetTouch(0);

            //Para movimentar o (Gelo) com os gestos do toque na tela do jogo
            if (toque.phase == TouchPhase.Moved)
            {

                //Para movimentar o (Gelo)
                transform.position = new Vector2(transform.position.x + toque.deltaPosition.x * velocidade, transform.position.y + toque.deltaPosition.y * velocidade);
            }
        }
    }
}
