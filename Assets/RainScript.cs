using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainScript : MonoBehaviour
{
    public GameObject rainPrefab;
    public int rainAmount = 100;
    public float interval = 1.0f;
    public float height = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rain());
    }


    IEnumerator Rain()
    {
        while (true)
        {
            for (int i = 0; i < rainAmount; i++)
            {
                Vector3 randomPos = RandomPosition();
                randomPos.y += height;

                Instantiate(rainPrefab, randomPos, Quaternion.identity);
            }

            yield return new WaitForSeconds(interval);
        }
    }

    Vector3 RandomPosition()
    {
        Vector3 min = new Vector3(0, 0, 0);
        Vector3 max = new Vector3(0.519f, 0.21f, 1.0688f);
        float randomX = Random.Range(min.x, max.x);
       // float randomY = Random.Range(min.y, max.y);
        float randomZ = Random.Range(min.z, max.z);

        return new Vector3(randomX, 0, randomZ);
    }
}
