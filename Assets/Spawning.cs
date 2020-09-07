using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject coinPrefab;
    private float nextTimeTospawn = 0f;

    // Update is called once per frame
    void Update()
    {
            float randomY = Random.Range(-2f, 4.4f);
            if(Time.time >= nextTimeTospawn)
            {
                nextTimeTospawn = Time.time + 1;
                Instantiate(coinPrefab, new Vector2(12f, randomY), Quaternion.identity);
            }
    }
}
