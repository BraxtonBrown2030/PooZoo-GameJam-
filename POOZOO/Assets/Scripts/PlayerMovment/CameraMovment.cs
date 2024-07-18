using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class CameraMovment : MonoBehaviour
{

    public Camera playercamera;
    public UnityEvent onCick;
    public Vector3 postion;

    public void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            
            Vector3 mousePosition = Input.mousePosition;
            Vector3 worldPosition = playercamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, playercamera.nearClipPlane));
            playercamera.transform.position = worldPosition;
            
        }
        
        
        
        
        
    }
}
