using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public GameManager Game_Manager;
    public Animator HummerAnimator,RedButtonAnimator;
    public bool FinishGame=false;
    
  //---------- mouse kýrmýzý butona týklayýnca oyun devam ediyor ise çekiçe vurmayý yaptýr ve 1 hamle hakký azalt
    private void OnMouseDown()
    {
        if (!FinishGame)
        {
            HummerAnimator.SetBool("Damage", true);
            Game_Manager.DamageQuantity--;
            RedButtonAnimator.SetBool("Active", true);

            Debug.Log("Butona Týkladý");
        }
        //--------------------- mouse kýrmýzý butona týklayýnca oyun devam etmiyor ise hamle hakkýnýn bittiði bildir
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
