using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
 
   private RaycastHit hit;
   private PickupItem Item { get; set; }
    private bool hasItem;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (hasItem)
        {
            CheckDrop();
        }
        else
        {
            CheckPickup();
        }
    }

    private void CheckPickup()
    {
        if(Physics.Raycast(transform.position,transform.forward,out hit,50f))
        {
            if (hit.collider.gameObject.TryGetComponent<IPickupItem>(out IPickupItem item) && Item == null)
            {
            
                if (Input.GetKeyDown(KeyCode.F) && !hasItem)
                {
                    Item = (PickupItem)hit.collider.gameObject.GetComponent<IPickupItem>();
                    hasItem = true;
                   
                    Item.Pickup(transform);
                }
            }
        }
    }



    private void CheckDrop()
    {
        if (Input.GetKeyDown(KeyCode.F) && hasItem)
        {
            hasItem = false;
            Item.drop(transform);
            Item = null;
        }
    }
}
  



