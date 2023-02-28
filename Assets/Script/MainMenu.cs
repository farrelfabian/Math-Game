using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text HS_Add, HS_Div, HS_Mult, HS_Sub;

    private void Start()
    {
        HS_Add.text = "Penjumlahan : " + PlayerPrefs.GetInt("HSkor_Add");
        HS_Sub.text = "Pengurangan : " + PlayerPrefs.GetInt("HSkor_Sub");
        HS_Mult.text = "Perkalian : " + PlayerPrefs.GetInt("HSkor_Mult");
        HS_Div.text = "Pembagian : " + PlayerPrefs.GetInt("HSkor_Div");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Map");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!!!");
        Application.Quit();
    }
}
