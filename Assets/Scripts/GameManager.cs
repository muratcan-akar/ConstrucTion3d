using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Animator PlacmentCubeAnimator;
    public GameObject GameOverUý, WinnerUý, Warning;
    public RedButton Red_Button;
    public int DamageQuantity;
    public Text DamageQuantityText;

    //----------------------- Baþlangýçta uý larý gösterme Hamle sayýsýný 9 ver---------------
    void Start()
    {

        GameOverUý.SetActive(false);
        WinnerUý.SetActive(false);
        Warning.SetActive(false);
        DamageQuantity = 9;
    }

    //----------- yerleþtir butonuna basýnca küpü yerine götür 1.5 saniye sonra kazanma ekranýný aç-------------
   public void FinishButon()
    {
        PlacmentCubeAnimator.SetBool("CubeActive", true);
        Invoke("WinnerActive",1.5f);

    }
    //---------Restart butouna basýnca zamaný oynat oyunu yeniden baslat------------
    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    // --------------------------------winner ekranýný göster---------------------------
    public void WinnerActive()
    {
        
        WinnerUý.SetActive(true);
    }
    //----------------------------gameover ekranýný göster ve 0.5 sanoye sonra zamaný durudur-------------------------------
    public void GameOverActive()
    {
        GameOverUý.SetActive(true);
        Invoke("StopTime", 0.5f);
        Debug.Log("OyunKaybedildi");
    }
    public void StopTime()
    {
        Time.timeScale = 0;
    }

    // ------------------------------------Vuruþ hakkýný ekrana yaz ve 0 kaldýðý zaman vuruþ yaptýrma-----------------
    void Update()
    {
        DamageQuantityText.text = "Vuruþ Hakký: " + DamageQuantity;

        if(DamageQuantity == 0)
        {
            Red_Button.FinishGame = true;
           
        }

    }
}
