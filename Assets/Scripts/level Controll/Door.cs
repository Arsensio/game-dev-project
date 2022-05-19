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
            if (Input.GetKeyDown(KeyCode.R))
            {
                controller.moveToNexDoor(nextDoor);
            }
        }
    }
}
