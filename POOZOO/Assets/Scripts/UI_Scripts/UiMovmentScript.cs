using UnityEngine;

public class UiMovmentScript : MonoBehaviour
{
    public Canvas thisCanvas;
    public Vector2 movepostion1;
    public Vector2 movepostion2;
    
    public void MoveCanvastest()
    {
        Vector2 currentPosition = new Vector2(thisCanvas.transform.position.x, thisCanvas.transform.position.y);
        Vector2 canvasSize = thisCanvas.GetComponent<RectTransform>().sizeDelta;

        if(currentPosition == movepostion1)
        {
            thisCanvas.transform.position = new Vector3(movepostion2.x + canvasSize.x, movepostion2.y + canvasSize.y, thisCanvas.transform.position.z);
        }
        else
        {
            thisCanvas.transform.position = new Vector3(movepostion1.x, movepostion1.y, thisCanvas.transform.position.z);
        }
    }
    
}
