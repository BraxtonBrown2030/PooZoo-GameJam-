using UnityEngine;
using UnityEngine.Events;

public class CameraMovment : MonoBehaviour
{

    public Camera playercamera;
    public Vector3 postion;
    public bool mousedown;
    public float speed = 5f;

    public void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            mousedown = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mousedown = false;
        }

        if (mousedown)
        {
            
            Vector3 mousePosition = Input.mousePosition;
            Vector3 worldPosition = playercamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, playercamera.nearClipPlane));
            worldPosition.z = playercamera.transform.position.z;
            playercamera.transform.position = Vector3.Lerp(playercamera.transform.position, worldPosition, speed * Time.deltaTime);
            
        }


    }
}