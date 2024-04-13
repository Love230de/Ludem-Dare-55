using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour , IPickupItem
{
    [SerializeField] private Rigidbody rb;
    
   public void drop(Transform player)
    {
        //Do stuff other than dropping
        transform.SetParent(null);
        rb.isKinematic = false;
       
    }

    public void Pickup(Transform player)
    {

        //Do stuff other than picking up
       
        rb.isKinematic = true;
        transform.position = player.position + player.forward * 1.5f;
     
        transform.SetParent(player);
    }
}
