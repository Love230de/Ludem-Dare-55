using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DropZone : MonoBehaviour
{

 

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<IPickupItem>(out IPickupItem item))
        {




            GameController.instance.IncreaseItems();
            item.drop(transform);
                 
             Destroy(other.gameObject);


                
            
        }
    }

}
