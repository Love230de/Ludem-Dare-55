using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidyDoor : MonoBehaviour
{
    [SerializeField] private Transform door;
    [SerializeField] private Vector3 destination;
    private bool entered;
    private void OnTriggerEnter(Collider other)
    {
        if (!entered)
        {
            entered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (entered)
        {
            entered = false;
        }
    }

    private void Update()
    {
        if(entered)
        {
            destination = Vector3.up * 5;
        }
        else
        {
            destination = Vector3.up;
        }
       door.transform.localPosition = Vector3.MoveTowards(door.transform.localPosition, destination, Time.deltaTime);
    }
}
