using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFloor : MonoBehaviour
{
    BoxCollider2D collider;
    public GameObject floor;
    public GameObject person;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput < -0.1f)
        {
            floor.GetComponent<BoxCollider2D>().isTrigger = true;
        }   
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player" && collider.bounds.Contains(col.bounds.min))
        {
            floor.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
