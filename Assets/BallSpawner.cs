using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    
    public GameObject ballPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;

            mousePos.z = 0.05f;

            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            SpawnBall(worldPos);
        }
    }

    void SpawnBall(Vector3 position)
    { 
        Instantiate(ballPrefab, position, Quaternion.identity);
    }
}
