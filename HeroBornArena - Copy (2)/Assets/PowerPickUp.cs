using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPickUp : MonoBehaviour
{   public GameBehavior gameManager;
    //1
    void OnCollisionEnter(Collision collision)
    {
        //2
        if (collision.gameObject.name == "Player")
        {
            //3
            Destroy(this.transform.parent.gameObject);

            //4
            Debug.Log("Hammer Get!");
            
        }
         gameManager.Items += 1;
 // 4
    gameManager.PrintLootReport();
    }
   
}
