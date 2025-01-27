using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoFogo : MonoBehaviour
{

    //Esse script é para destruir o (Fogo) quando ele bater no (Chão)

    //Para passar o (GameObjects)
    public GameObject fogo1;
    public GameObject fogo2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método para checar colisão
    private void OnCollisionEnter2D(Collision2D colisao)
    {

        //Para quando o (Fogo) colidir com o (Chão)
        if (colisao.gameObject.CompareTag("Chao"))
        {

            //Para destruir o (Fogo)
            Destroy(this.gameObject);
        }
    }
}
