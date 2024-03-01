using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public PlayerCapsule player;
    //1
    void OnCollisionEnter (Collision collision)
    { 
        //2
        if (collision.gameObject.name == "Player")
        {
            //3
            Destroy(this.transform.parent.gameObject);

            speedBoost();
            
            //4
            Debug.Log("Speed Up!");
        }
    }
    void speedBoost()
    {
        player.moveSpeed *= 2;
        Invoke("endspeedBoost", 5);

    }
    void endspeedBoost()
    {
        player.moveSpeed /= 2;
    }
}
