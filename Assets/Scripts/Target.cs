using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager Game_Manager;
    

    public Animator TargetAnimator;
   // ---------------------ceki� carpt��� zaman hedefin yok olma animasyonunu �al��t�r ----------
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hummer")
        {
            Debug.Log("�eki� vurdu!");
            TargetAnimator.SetBool("TargetActive",true);


        }
        // ---------------bana yerle�ecek kutu �arpar ise gameover ekran�n� cal��t�r----------------
        if (other.gameObject.tag == " PlacmentCub")
        {

            Game_Manager.GameOverActive();

        }
    }

   
}
