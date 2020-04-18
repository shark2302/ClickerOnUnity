using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;


[RequireComponent(typeof(BoxCollider2D))]
public class Spawner : MonoBehaviour
{
    [Header("Object creation")] 
    public GameObject prefabToSpawn; 
    
    [Header("Other options")]
    public float spawnInterval = 1;
    
    private BoxCollider2D boxCollider2D;
    private List<GameObject> _asteroidList;

    void OnEnable ()
    {
       _asteroidList = new List<GameObject>();
        boxCollider2D = GetComponent<BoxCollider2D>();

        StartCoroutine(SpawnObject());
    }

    private void OnDisable()
    {
        foreach (var asteroid in _asteroidList)
        {
            if(asteroid != null) 
                Destroy(asteroid);
        }

       
    }

    public List<GameObject> GetAsteroidList()
    {
        return _asteroidList;
    }
	
    
    IEnumerator SpawnObject ()
    {
        while(true)
        {
            
            float randomX = Random.Range (-boxCollider2D.size.x, boxCollider2D.size.x) *.5f;
            float randomY = Random.Range (-boxCollider2D.size.y, boxCollider2D.size.y) *.5f;

            
            GameObject newObject = Instantiate<GameObject>(prefabToSpawn);
            newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
            _asteroidList.Add(newObject);
            
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    
    

    
}