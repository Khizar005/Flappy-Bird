using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private readonly float deadZone = -45f;
   
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }

}
