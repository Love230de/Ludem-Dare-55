using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform dummbyDoor;

    [SerializeField] private Transform button;
    public void Activate()
    {
        //Animates a button and activates a door object for now
        dummbyDoor.gameObject.SetActive(true);
        button.transform.position = button.transform.position * 0.5f;
    }

    public void Deactivate()
    {
        //Animates a button and deactivates a door object for now
        dummbyDoor.gameObject.SetActive(false);
        button.transform.position = button.transform.position * 1;
    }
}
