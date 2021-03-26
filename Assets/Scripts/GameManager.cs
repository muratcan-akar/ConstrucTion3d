using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Animator PlacmentCubeAnimator;
    public GameObject GameOverU�, WinnerU�, Warning;
    public RedButton Red_Button;
    public int DamageQuantity;
    public Text DamageQuantityText;

    //----------------------- Ba�lang��ta u� lar� g�sterme Hamle say�s�n� 9 ver---------------
    void Start()
    {

        GameOverU�.SetActive(false);
        WinnerU�.SetActive(false);
        Warning.SetActive(false);
        DamageQuantity = 9;
    }

    //----------- yerle�tir butonuna bas�nca k�p� yerine g�t�r 1.5 saniye sonra kazanma ekran�n� a�-------------
   public void FinishButon()
    {
        PlacmentCubeAnimator.SetBool("CubeActive", true);
        Invoke("WinnerActive",1.5f);

    }
    //---------Restart butouna bas�nca zaman� oynat oyunu yeniden baslat------------
    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    // --------------------------------winner ekran�n� g�ster---------------------------
    public void WinnerActive()
    {
        
        WinnerU�.SetActive(true);
    }
    //----------------------------gameover ekran�n� g�ster ve 0.5 sanoye sonra zaman� durudur-------------------------------
    public void GameOverActive()
    {
        GameOverU�.SetActive(true);
        Invoke("StopTime", 0.5f);
        Debug.Log("OyunKaybedildi");
    }
    public void StopTime()
    {
        Time.timeScale = 0;
    }

    // ------------------------------------Vuru� hakk�n� ekrana yaz ve 0 kald��� zaman vuru� yapt�rma-----------------
    void Update()
    {
        DamageQuantityText.text = "Vuru� Hakk�: " + DamageQuantity;

        if(DamageQuantity == 0)
        {
            Red_Button.FinishGame = true;
           
        }

    }
}
