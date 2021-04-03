using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public Camera MainCamera;
    private Vector2 ScreenBounds;
    private float ObjectWidth;
    private float ObjectHeight;
    public Transform PlayerDeathCheck;

    void Start()
    {
        PlayerDeathCheck = GetComponent<Transform>();
        MainCamera = Camera.FindObjectOfType<Camera>();
        ScreenBounds = MainCamera.ScreenToWorldPoint(new Vector3(
            Screen.width, 
            Screen.height, 
            MainCamera.transform.position.z));
        ObjectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        ObjectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, ScreenBounds.x * -1 + ObjectWidth, ScreenBounds.x - ObjectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, ScreenBounds.y * -1 + ObjectHeight, ScreenBounds.y - ObjectHeight);
        transform.position = viewPos;
    }
    void Update()
    {
        if (PlayerDeathCheck == null)
            return;
    }
}
