using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(waitSeconds(10f));
    }

    IEnumerator waitSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Instantiate(enemy);
    }
}
