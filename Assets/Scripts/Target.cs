using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager Game_Manager;
    

    public Animator TargetAnimator;
   // ---------------------cekiç carptýðý zaman hedefin yok olma animasyonunu çalýþtýr ----------
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hummer")
        {
            Debug.Log("Çekiç vurdu!");
            TargetAnimator.SetBool("TargetActive",true);


        }
        // ---------------bana yerleþecek kutu çarpar ise gameover ekranýný calýþtýr----------------
        if (other.gameObject.tag == " PlacmentCub")
        {

            Game_Manager.GameOverActive();

        }
    }

   
}
