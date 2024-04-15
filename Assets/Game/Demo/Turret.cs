using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Turret : MonoBehaviour
{
    //Barrel Reference
    [SerializeField] private StarterAssetsInputs _input;
   public void SetParentToTurret(Transform transform)
    {
        transform.parent = transform;
    }

    private void Update()
    {
        //If fireButton then barrelReferenceFire Bullets
        if(_input.fire)
        {

        }
    }

}
