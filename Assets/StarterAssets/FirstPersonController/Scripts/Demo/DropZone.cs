using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DropZone : MonoBehaviour
{

    private int items { get; set; }
    [SerializeField] private float maxItem;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<IItem>(out IItem item))
        {

            if (items < maxItem)
            {
              
                    item.drop(transform);
                    items++;
                    Destroy(other.gameObject);


                
            }
        }
    }

    private void Update()
    {
        if(items >= maxItem)
        {
            Debug.Log("Win");
        }
    }

}
