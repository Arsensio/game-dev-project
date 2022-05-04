using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform nextDoor;
    [SerializeField] private Movement controller;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("key enter");
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("key pressed");
                controller.moveToNexDoor(nextDoor);
            }
        }
    }
}
