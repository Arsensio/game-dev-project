using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDisableWallRight : MonoBehaviour
{
    BoxCollider2D collider;
    public GameObject triggerObject;
    public GameObject person;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput < -0.1f)
        {
            triggerObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        else
        {
            triggerObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
