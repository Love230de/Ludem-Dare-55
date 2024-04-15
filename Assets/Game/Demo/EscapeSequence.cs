using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EscapeSequence : MonoBehaviour
{
    [SerializeField] private float spaceStationHealth;
    [SerializeField] private FirstPersonController firstPersonController;
    [SerializeField] private Turret turret;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.instance.Escape)
        {

           firstPersonController.transform.SetParent(transform, false);
           turret.enabled = true;
           
        }

    }
}
