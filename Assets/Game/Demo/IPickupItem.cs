using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickupItem 
{
    public void Pickup(Transform player);

    public void drop();
}
