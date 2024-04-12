using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.VFX;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject squarePrefab;
    [SerializeField] float timeBetweenSpawns;
    float spawnElapsed = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject g = Instantiate(squarePrefab);
        g.transform.position = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        spawnElapsed += Time.deltaTime;

        if (spawnElapsed >= timeBetweenSpawns)
        {
            Spawn();
            spawnElapsed = 0;
        }
    }


    private void Spawn()
    {
        GameObject g = Instantiate(squarePrefab.gameObject, transform);
        //Screen.width
        int r = Random.Range(90, 100);
        g.transform.position = new Vector3(r, r, r);
        Destroy(g.gameObject, 2);
    }
}
