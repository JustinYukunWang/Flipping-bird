using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipspawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float height = 8;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnpipe();
        }
    }

    void spawnpipe()
    {
        float highest = transform.position.y + height;
        float lowest = transform.position.y - height;
        Instantiate(pipe, new Vector3 (transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
    }
}
