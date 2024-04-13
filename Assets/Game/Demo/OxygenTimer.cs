using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class OxygenTimer 
{
    private bool empty { get; set; }
    private float seconds;
    public GameObject GaugeArrow;
    public bool Empty { get { return empty; } }
    public float OxygenAmount { get { return seconds; } }   
    public float maxSeconds;
   

    void GaugeFunctionality()
    {
        float currentOxygen = (seconds / maxSeconds) * 100;

        float angle = GaugeArrow.transform.localEulerAngles.z;

        angle -= Time.deltaTime;

        angle = Mathf.Clamp(angle, -currentOxygen * 0.90f, currentOxygen * 0.90f);
        
        GaugeArrow.transform.localEulerAngles = new Vector3(0, 0, angle); 
    }
   public void UpdateOxygenTimer()
    {
    
        if(seconds > 0)
        {
            seconds -= Time.deltaTime;
            GaugeFunctionality();
        }
        else if(!empty) 
        {
            empty = true;
            seconds = maxSeconds;
        }
       
    }
}
