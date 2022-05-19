using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform CameraPosition1;
    [SerializeField] private Transform CameraPosition2;
    private float speed = 0.5f;
    private float currentPosY;
    private Vector3 velocity = Vector3.zero;

    public void Start()
    {
        currentPosY = transform.position.y;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentPosY = CameraPosition1.position.y;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            currentPosY = CameraPosition2.position.y;
        }
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, currentPosY, transform.position.z), ref velocity, speed);
    }

}
