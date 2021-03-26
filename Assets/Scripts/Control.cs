using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Transform Consol;
    public Transform Hummer;
   
    public float HorizontalMove, VerticalMove;
    

   

    private void Update()
    {

      
        HorizontalMove = Input.GetAxis("Horizontal");
        VerticalMove = Input.GetAxis("Vertical");

        // klavye tuþlarýn dan gelen deðeri konsolun eðilme hareketlerinde kullan  olar konsolda kullan 

        Consol.rotation = Quaternion.Euler(VerticalMove * 10, 0, HorizontalMove * -10);

        // klavye tuþlarýndan gelen deðeri çekicin hareketinde kullan
        Hummer.position = new Vector3(Hummer.position.x+HorizontalMove*Time.deltaTime, Hummer.position.y+VerticalMove*Time.deltaTime, Hummer.position.z);

    }
   


}
