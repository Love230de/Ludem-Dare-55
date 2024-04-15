using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenFadeOut : MonoBehaviour
{
    private Image imageComponent;
    [SerializeField] private float fadeStartPercent = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        var oxygenTimer = GameController.instance.oxygenTimer;
        var ratio = oxygenTimer.OxygenAmount / oxygenTimer.maxSeconds;
        var fadeStartRatio = fadeStartPercent / 100.0f;
        if (ratio < fadeStartRatio)
        {
            var color = imageComponent.color;
            color.a = 1 - (ratio / fadeStartRatio);
            imageComponent.color = color;
        }
        else
        {
            var color = imageComponent.color;
            color.a = 0f;
            imageComponent.color = color;
        }
    }
}
