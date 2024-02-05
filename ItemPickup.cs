using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PlayerCapsule")
        {
            Destroy(transform.parent.gameObject);
            
            Debug.Log("Item Collected!");
        }
    }
}
