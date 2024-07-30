using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public Vector3 movmentdriction;
    public float movmentdistince;

    private void Start()
    {
        StartCoroutine(MovementRoutine());
    }

    private IEnumerator MovementRoutine()
    {
        while (true)
        {
            movmentdriction = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
            movmentdistince = Random.Range(8, 10);

            float moveSpeed = movmentdistince * Time.deltaTime; // calculate this first
            transform.position += movmentdriction * moveSpeed; // then multiply with the vector

            yield return new WaitForSeconds(1); // wait for 4 seconds before the next movement
        }
    }
    
    

}
