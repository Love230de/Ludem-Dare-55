using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    float resetTime = 1.0f;
    float seconds = 0;
    // Start is called before the first frame update
    void Start()
    {
      Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 200 * Time.deltaTime);

      if(seconds < resetTime)
        {
            seconds += Time.deltaTime;
        }
      else
        {
          //  SceneManager.LoadScene(0);
        }
    }
}
