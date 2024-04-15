using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DropZone : MonoBehaviour
{

    [SerializeField] private GameObject[] transmitter;
    private int index;
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
        if (index > 0)
        {
            transmitter[index - 1].SetActive(false);
        }
    }

}
