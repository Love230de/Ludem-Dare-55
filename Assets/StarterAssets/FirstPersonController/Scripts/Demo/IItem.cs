using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem 
{
    public void Pickup(Transform player);

    public void drop(Transform player);
}
