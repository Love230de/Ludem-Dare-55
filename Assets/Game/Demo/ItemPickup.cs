using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
 
   private RaycastHit hit;
   private PickupItem testItem { get; set; }
    private bool hasItem;
    private void Start()
    {
        
    }
    private void FixedUpdate()
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
        if(Physics.Raycast(transform.position,transform.forward,out hit,5f))
        {
            if (hit.collider.gameObject.TryGetComponent<IPickupItem>(out IPickupItem item) && testItem == null)
            {
             
                if (Input.GetKeyDown(KeyCode.F) && !hasItem)
                {
                    testItem = (PickupItem)hit.collider.gameObject.GetComponent<IPickupItem>();
                    hasItem = true;
                   
                    testItem.Pickup(transform);
                }
            }
        }
    }

    private void Update()
    {
    }

    private void CheckDrop()
    {
        if (Input.GetKeyDown(KeyCode.F) && hasItem)
        {
            hasItem = false;
            testItem.drop(transform);
            testItem = null;
        }
    }
}
  



