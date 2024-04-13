using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class OxygenTimer 
{
    private bool empty { get; set; }
    private float seconds;
    public bool Empty { get { return empty; } }
    public float OxygenAmount { get { return seconds; } }   
    public float maxSeconds;
   
   public void UpdateOxygenTimer()
    {
    
        if(seconds > 0)
        {
            seconds -= Time.deltaTime;
      
        }
        else if(!empty) 
        {
            empty = true;
            seconds = maxSeconds;
        }
    }
}
