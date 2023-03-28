using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 5;
    public GameObject prefabPipe;
    public GameObject prefabPipe2;
    public GameObject prefabCoin;

    // Update is called once per frame
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnRandom();
        }
        timer += Time.deltaTime;
    }

    private void SpawnRandom(){
     int prefabIndex = UnityEngine.Random.Range(0,2);
        if(prefabIndex == 0)
        {
            SpawnPipe2();
            SpawnCoin();
            
        }
        else
        {
            SpawnPipe();
        }
    }

    private void SpawnPipe()
    {
        GameObject newPipe = Instantiate(prefabPipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 10f);
    }
    private void SpawnPipe2()
    {
        GameObject newPipe2 = Instantiate(prefabPipe2);
        newPipe2.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe2, 10f);
    }
    private void SpawnCoin()
    {
        GameObject newCoin = Instantiate(prefabCoin);
        newCoin.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newCoin,3.5f);
    }
}
