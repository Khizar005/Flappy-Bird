using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject Pipe;

    public float spawnRate = 2f;
    private float timer = 0;
    private readonly float highOffset = 10f;
    float lowerstPoint, higherPoint;


    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;

        }
        else
        {
            SpawnPipe();
            timer = 0;
        }

    }
    public void SpawnPipe()
    {
         lowerstPoint = transform.position.y - highOffset;
         higherPoint = transform.position.y + highOffset;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowerstPoint, higherPoint), 0), Quaternion.identity);

    }

}
