using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    public float deadZone = -14;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
