using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDisableWallLeft : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            triggerObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        else
        {
            triggerObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
