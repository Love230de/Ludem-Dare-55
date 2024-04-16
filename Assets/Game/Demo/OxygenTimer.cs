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
        float currentOxygen = (seconds / maxSeconds);

        float angle = Mathf.Lerp(90, -90, currentOxygen);
        
        GaugeArrow.transform.localEulerAngles = new Vector3(0, 0, angle); 
    }
  public void StartOxygen()
    {
        seconds = maxSeconds;
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
