using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour , IItem
{
    [SerializeField] private Rigidbody rb;
    
   public void drop(Transform player)
    {
        //Do stuff other than dropping
        transform.SetParent(null);
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }

    public void Pickup(Transform player)
    {

        //Do stuff other than picking up
       
        rb.isKinematic = true;
        transform.position = transform.position + Vector3.forward;
     
        transform.SetParent(player);
    }
}