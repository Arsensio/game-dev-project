using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public Background background;
    public Person person;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("check point changed");
            background.checkPoint = transform;
            person.startPosition = transform;
        }
    }
}
