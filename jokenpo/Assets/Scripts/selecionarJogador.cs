using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecionarJogador : MonoBehaviour
{
    private numeroSelecaoPersonagem _numeroSelecaoPersonagem;
    public GameObject[] personagem;
    public int numeroPersonagem;
    // Start is called before the first frame update

 
    void Start()
    {
        personagem[1].SetActive(false);
        personagem[2].SetActive(false);
        _numeroSelecaoPersonagem = FindObjectOfType(typeof(numeroSelecaoPersonagem)) as numeroSelecaoPersonagem;
    }

    // Update is called once per frame
    void Update()
    {


        if(numeroPersonagem == 0)
        {
            personagem[0].SetActive(true);
            personagem[1].SetActive(false);
            personagem[2].SetActive(false);
        }
        if(numeroPersonagem == 1)
        {
            personagem[0].SetActive(false);
            personagem[1].SetActive(true);
            personagem[2].SetActive(false);
        }
        if (numeroPersonagem == 2)
        {
            personagem[0].SetActive(false);
            personagem[1].SetActive(false);
            personagem[2].SetActive(true);
        }

        if( numeroPersonagem > 2) {
            numeroPersonagem = 2;
        }
        if (numeroPersonagem < 0)
        {
            numeroPersonagem = 0;
        }

        _numeroSelecaoPersonagem.numeroPersonagem = numeroPersonagem;
    }

    public void mudarPersonagemAvancar()
    {
        numeroPersonagem++;
    }
    public void mudarPersonagemRetornar()
    {
        numeroPersonagem--;
    }




}
