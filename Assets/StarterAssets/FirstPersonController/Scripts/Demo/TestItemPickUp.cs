using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItemPickUp : MonoBehaviour
{
 
   private RaycastHit hit;
   private Item testItem { get; set; }
    private bool hasItem;
    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
       
        if(Physics.Raycast(transform.position,transform.forward,out hit,5f))
        {
            if (hit.collider.gameObject.TryGetComponent<IItem>(out IItem item) && testItem == null)
            {
             
                if (Input.GetKey(KeyCode.F) && !hasItem)
                {
                    testItem = (Item)hit.collider.gameObject.GetComponent<IItem>();
                    hasItem = true;
                   
                    testItem.Pickup(transform);
                }
            }
        }

    }

    private void Update()
    {




        if (Input.GetKey(KeyCode.F) && hasItem)
        {
            hasItem = false;
         
          

        }
        if(!hasItem && hasItem)
        {
            testItem.drop(transform);
            ;
        }
    }
 }
  



