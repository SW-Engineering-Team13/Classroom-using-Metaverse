using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float repeateInterval;

    // Start is called before the first frame update
    void Start()
    {
        if(repeateInterval > 0){
            InvokeRepeating("SpawnObject", 0.0f, repeateInterval);
        }
        
    }

    public GameObject SpawnObject(){
        if(prefabToSpawn != null){
            return Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }

        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
