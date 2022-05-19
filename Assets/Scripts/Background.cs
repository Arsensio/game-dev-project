using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
    
    public float speed;
    public Transform checkPoint;

    void Start()
    {
        transform.position += Vector3.right * (transform.position.x - checkPoint.position.x);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.position += Vector3.right * (transform.position.x - checkPoint.position.x);
        }
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
    }
}
