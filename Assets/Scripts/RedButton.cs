using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public GameManager Game_Manager;
    public Animator HummerAnimator,RedButtonAnimator;
    public bool FinishGame=false;
    
  //---------- mouse k�rm�z� butona t�klay�nca oyun devam ediyor ise �eki�e vurmay� yapt�r ve 1 hamle hakk� azalt
    private void OnMouseDown()
    {
        if (!FinishGame)
        {
            HummerAnimator.SetBool("Damage", true);
            Game_Manager.DamageQuantity--;
            RedButtonAnimator.SetBool("Active", true);

            Debug.Log("Butona T�klad�");
        }
        //--------------------- mouse k�rm�z� butona t�klay�nca oyun devam etmiyor ise hamle hakk�n�n bitti�i bildir
        if (FinishGame)
        {
            Game_Manager.Warning.SetActive(true);
           


        }
       

        
    }
    
    void OnMouseUp()
    {
        HummerAnimator.SetBool("Damage", false);
        RedButtonAnimator.SetBool("Active", false);
    }


}
