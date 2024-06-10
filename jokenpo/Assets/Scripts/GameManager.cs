using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    private numeroSelecaoPersonagem _numeroSelecionarJogador;
    public int selecao;


    public GameObject[] jogador1;
    public GameObject[] jogador2;
    public int sorteioJogador1;
    public int sorteioJogador2;
    public GameObject jogadorGanhou1;
    public GameObject jogadorGanhou2;
    public GameObject jogadorEmpatou;
    public TextMeshProUGUI[] pontuacaoJogador;
    public int[] pontuacao;
    public bool isGanhouJogador1;
    public bool isGanhouJogador12;
    public bool isGanhouJogador2;
    public bool isGanhouJogador22;
    public Button jogar;

    //personagemRobo1
    [Header("personagemRobo1")]
    public Sprite[] avatar2;
    public Image imgAvatar2;
    //personagem1
    [Header("personagem1")]
    public Sprite[] avatarPersonagem1;
    public Image imgAvatarPersonagem1;
    //personagem2
    [Header("personagem2")]
    public Sprite[] avatarPersonagem2;
    public Image imgAvatarPer2;
    //personagem3
    [Header("personagem3")]
    public Sprite[] avatarPersonagem3;
    public Image imgAvatarPer3;
    [Header("Painel Configuração")]
    public GameObject painelConfiguracao;



    void Start()
    {

        _numeroSelecionarJogador = FindObjectOfType(typeof(numeroSelecaoPersonagem)) as numeroSelecaoPersonagem;
        selecao = _numeroSelecionarJogador.numeroPersonagem;

        if (selecao == 0)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[0];
        }
        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer2.sprite = avatarPersonagem2[0];

        }
        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer3.sprite = avatarPersonagem3[0];
        }

        for (int i = 0; i < jogador1.Length; i++)
        {
            jogador1[i].SetActive(false);
            jogador2[i].SetActive(false);
        }

        sorteioJogador1 = -1;
        sorteioJogador2 = -1;
        jogadorGanhou1.SetActive(false);
        jogadorGanhou2.SetActive(false);
        isGanhouJogador1 = false;
        jogadorEmpatou.SetActive(false);
        painelConfiguracao.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        // selecao = _numeroSelecionarJogador.numeroPersonagem;
        if (sorteioJogador2 < 0)
        {
            sorteioJogador2 = -1;
        }
        else
        {
            while (sorteioJogador1 == sorteioJogador2)
            {
                sorteioJogador2 = Random.Range(0, 3);
            }
        }
  


        if (sorteioJogador1 == 0 && isGanhouJogador12)
        {
            jogador1[0].SetActive(true);
            isGanhouJogador12 = false;

        }
        else
        if (sorteioJogador1 == 1 && isGanhouJogador12 )
        {
            jogador1[1].SetActive(true);
            isGanhouJogador12 = false;

        }
        else
        if (sorteioJogador1 == 2 && isGanhouJogador12)
        {
            jogador1[2].SetActive(true);
            isGanhouJogador12 = false;
  
        }

        if (sorteioJogador2 == 0  && isGanhouJogador22)
        {
            jogador2[0].SetActive(true);
         
            isGanhouJogador22 = false;
        }
        else

        if (sorteioJogador2 == 1 && isGanhouJogador22)
        {
            jogador2[1].SetActive(true);
         
            isGanhouJogador22 = false;
        }
        else

        if (sorteioJogador2 == 2  && isGanhouJogador22)
        {
            jogador2[2].SetActive(true);
           
            isGanhouJogador22 = false;
        }
        
        if(sorteioJogador1==0 && sorteioJogador2 == 1 && isGanhouJogador1 && isGanhouJogador2)
        {

            StartCoroutine(GanhouJogador01());

            isGanhouJogador1 = false;
            isGanhouJogador2 = false;

        }
        else if(sorteioJogador1 == 0 && sorteioJogador2 == 2 && isGanhouJogador1 && isGanhouJogador2)
        {

            StartCoroutine(GanhouJogador02());
 
            isGanhouJogador1 = false;
            isGanhouJogador2 = false;

        }
        else if (sorteioJogador1 ==1 && sorteioJogador2 == 0 && isGanhouJogador1 && isGanhouJogador2)
        {

            StartCoroutine(GanhouJogador10());

            isGanhouJogador1 = false;
            isGanhouJogador2 = false;

        }
        else if (sorteioJogador1 == 1 && sorteioJogador2 == 2 && isGanhouJogador1 && isGanhouJogador2)
        {

            StartCoroutine(GanhouJogador12());

            isGanhouJogador1 = false;
            isGanhouJogador2 = false;

        }
        else if (sorteioJogador1 == 2 && sorteioJogador2 == 0 && isGanhouJogador1 && isGanhouJogador2)
        {

            StartCoroutine(GanhouJogador20());

            isGanhouJogador1 = false;
            isGanhouJogador2 = false;

        }
        else if (sorteioJogador1 == 2 && sorteioJogador2 == 1 && isGanhouJogador1 && isGanhouJogador2)
        {

            StartCoroutine(GanhouJogador21());

            isGanhouJogador1 = false;
            isGanhouJogador2 = false;

        }

        else if (sorteioJogador1 == 0 && sorteioJogador2 == 0 && isGanhouJogador1 && isGanhouJogador2)
        {
           
            StartCoroutine(GanhouJogador00());

            isGanhouJogador1 = false;
            isGanhouJogador2 = false;
        }
        else if (sorteioJogador1 == 1 && sorteioJogador2 == 1 && isGanhouJogador1 && isGanhouJogador2)
        {

            StartCoroutine(GanhouJogador11());

            isGanhouJogador1 = false;
            isGanhouJogador2 = false;

        }
        else if (sorteioJogador1 == 2 && sorteioJogador2 == 2 && isGanhouJogador1 && isGanhouJogador2)
        {

            StartCoroutine(GanhouJogador22());

            isGanhouJogador1 = false;
            isGanhouJogador2 = false;

        }

        pontuacaoJogador[0].text = pontuacao[0].ToString();
        pontuacaoJogador[1].text = pontuacao[1].ToString();

    }

    #region
    public void PedraJogador1()
    {

        sorteioJogador1 = Random.Range(0, 3);
        isGanhouJogador1 = true;
        isGanhouJogador12 = true;


        sorteioJogador2 = Random.Range(0, 3);
        isGanhouJogador2 = true;
        isGanhouJogador22 = true;
        jogar.interactable = false;
    }
    public void PedraJogador2()
    {
        sorteioJogador2 = Random.Range(0, 3);
        isGanhouJogador2 = true;
        isGanhouJogador22 = true;
    }


    IEnumerator GanhouJogador01()
    {
        yield return new WaitForSeconds(2f);

        if (selecao == 0)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[2];
        }


        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPer2.sprite = avatarPersonagem2[2];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPer3.sprite = avatarPersonagem3[2];
        }

        jogadorGanhou2.SetActive(true);

        pontuacao[1]++;
        yield return new WaitForSeconds(4f);
        jogadorGanhou2.SetActive(false);
        jogador1[0].SetActive(false);
        jogador2[1].SetActive(false);

        if (selecao == 0)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[0];
        }

        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer2.sprite = avatarPersonagem2[0];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer3.sprite = avatarPersonagem3[0];
        }

        jogar.interactable = true;

    }
    IEnumerator GanhouJogador02()
    {
        yield return new WaitForSeconds(2f);
        jogadorGanhou1.SetActive(true);
        if(selecao == 0)
        {
            imgAvatarPersonagem1.sprite = avatarPersonagem1[1];
            imgAvatar2.sprite = avatar2[2];
        }
        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[2];
            imgAvatarPer2.sprite = avatarPersonagem2[1];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[2];
            imgAvatarPer3.sprite = avatarPersonagem3[1];
        }
        pontuacao[0]++;
        yield return new WaitForSeconds(4f);
        jogadorGanhou1.SetActive(false);
        jogador1[0].SetActive(false);
        jogador2[2].SetActive(false);
        if (selecao == 0)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[0];
        }
        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer2.sprite = avatarPersonagem2[0];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer3.sprite = avatarPersonagem3[0];
        }

        jogar.interactable = true;

    }

    IEnumerator GanhouJogador10()
    {
        yield return new WaitForSeconds(2f);
        jogadorGanhou1.SetActive(true);

        if(selecao == 0)
        {
            imgAvatar2.sprite = avatar2[2];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[1];
        }

        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[2];
            imgAvatarPer2.sprite = avatarPersonagem2[1];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[2];
            imgAvatarPer3.sprite = avatarPersonagem3[1];
        }

        pontuacao[0]++;
        yield return new WaitForSeconds(4f);
        jogadorGanhou1.SetActive(false);
        jogador1[1].SetActive(false);
        jogador2[0].SetActive(false);
 
        if (selecao == 0)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[0];
        }

        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer2.sprite = avatarPersonagem2[0];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer3.sprite = avatarPersonagem3[0];
        }

        jogar.interactable = true;
    }

    IEnumerator GanhouJogador12()
    {
        yield return new WaitForSeconds(2f);
        jogadorGanhou2.SetActive(true);


        if(selecao == 0)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[2];
        }

        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPer2.sprite = avatarPersonagem2[2];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPer3.sprite = avatarPersonagem3[2];
        }

        pontuacao[1]++;
        yield return new WaitForSeconds(4f);
        jogadorGanhou2.SetActive(false);
        jogador1[1].SetActive(false);
        jogador2[2].SetActive(false);

        if (selecao == 0)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[0];
        }
        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer2.sprite = avatarPersonagem2[0];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer3.sprite = avatarPersonagem3[0];
        }

        jogar.interactable = true;

    }

    IEnumerator GanhouJogador20()
    {
        yield return new WaitForSeconds(2f);
        jogadorGanhou2.SetActive(true);

        if(selecao == 0)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[2];
        }

        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPer2.sprite = avatarPersonagem2[2];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[1];
            imgAvatarPer3.sprite = avatarPersonagem3[2];
        }

        pontuacao[1]++;
        yield return new WaitForSeconds(4f);
        jogadorGanhou2.SetActive(false);
        jogador1[2].SetActive(false);
        jogador2[0].SetActive(false);

        if(selecao == 0)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[0];
        }

        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer2.sprite = avatarPersonagem2[0];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer3.sprite = avatarPersonagem3[0];
        }

        jogar.interactable = true;

    }

    IEnumerator GanhouJogador21()
    {
        yield return new WaitForSeconds(2f);
        jogadorGanhou1.SetActive(true);

        if(selecao == 0)
        {
            imgAvatar2.sprite = avatar2[2];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[1];
        }

        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[2];
            imgAvatarPer2.sprite = avatarPersonagem2[1];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[2];
            imgAvatarPer3.sprite = avatarPersonagem3[1];
        }

        pontuacao[0]++;
        yield return new WaitForSeconds(4f);
        jogadorGanhou1.SetActive(false);
        jogador1[2].SetActive(false);
        jogador2[1].SetActive(false);

        if(selecao == 0)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPersonagem1.sprite = avatarPersonagem1[0];
        }

        if (selecao == 1)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer2.sprite = avatarPersonagem2[0];
        }


        if (selecao == 2)
        {
            imgAvatar2.sprite = avatar2[0];
            imgAvatarPer3.sprite = avatarPersonagem3[0];
        }

        jogar.interactable = true;
    }

    IEnumerator GanhouJogador00()
    {
         yield return new WaitForSeconds(1f);
        jogadorEmpatou.SetActive(true);
        pontuacao[0]++;
        pontuacao[1]++;
        yield return new WaitForSeconds(4f);
        jogadorEmpatou.SetActive(false);
        jogador1[0].SetActive(false);
        jogador2[0].SetActive(false);
        jogar.interactable = true;

    }
    IEnumerator GanhouJogador11()
    {
         yield return new WaitForSeconds(1f);
        jogadorEmpatou.SetActive(true);
        pontuacao[0]++;
        pontuacao[1]++;
        yield return new WaitForSeconds(4f);
        jogadorEmpatou.SetActive(false);
        jogador1[1].SetActive(false);
        jogador2[1].SetActive(false);
        jogar.interactable = true;

    }
    IEnumerator GanhouJogador22()
    {
         yield return new WaitForSeconds(1f);
        jogadorEmpatou.SetActive(true);
        pontuacao[0]++;
        pontuacao[1]++;
        yield return new WaitForSeconds(4f);
        jogadorEmpatou.SetActive(false);
        jogador1[2].SetActive(false);
        jogador2[0].SetActive(false);
        jogar.interactable = true;

    }
    #endregion
    public void retornarJogo()
    {
        painelConfiguracao.SetActive(false);
    }

    public void acessarConfiguracao()
    {
        painelConfiguracao.SetActive(true);
    }

    public void sairJogo()
    {
        Application.Quit();
    }
}
