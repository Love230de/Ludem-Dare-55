using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DropZone : MonoBehaviour
{

    [SerializeField] private GameObject[] transmitter;
    private int index = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<IPickupItem>(out IPickupItem item))
        {




            GameController.instance.IncreaseItems();
            item.drop();
                 
             Destroy(other.gameObject);

            if (index < transmitter.Length-1)
            {


                index++;
            }    
            
        }
    }
    private void Update()
    {
        transmitter[index].SetActive(true);
    }

}
