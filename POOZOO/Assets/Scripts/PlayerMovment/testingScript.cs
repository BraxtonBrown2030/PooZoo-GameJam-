using UnityEditor;
using UnityEngine;

public class testingScript : MonoBehaviour
{
    

    public float radius = 10f;

    private void OnDrawGizmos()
    {
        Handles.color = Color.white;
        Handles.DrawWireDisc(transform.position, Vector3.up, radius);
    }
    

}
