using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mujdarCena : MonoBehaviour
{
    public void mudarCena()
    {
        SceneManager.LoadScene("GamePlayer");
    }
    public void Sair()
    {
        Application.Quit();
    }
    public void Iniciar()
    {
        SceneManager.LoadScene("SelecaoPersonagem");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Start");
    }
}
