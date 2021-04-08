using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLimits : MonoBehaviour
{
    Rect top;
    Rect bottom;
    Touch touch;

    void Update()
    {
        top = new Rect(0, 0, Screen.width, Screen.height / 2);
        bottom = new Rect(0, 0, Screen.height / 2, Screen.width);

        touch = Input.GetTouch(2);

        if (Input.touchCount > 0)
        {
            if (top.Contains(touch.position))
            {
                Debug.Log("Top touched");
            }
            else if (bottom.Contains(touch.position))
            {
                Debug.Log("Bottom touched");
            }
        }
    }
}

