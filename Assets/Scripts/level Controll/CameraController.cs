using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform CameraPosition1;
    [SerializeField] private Transform CameraPosition2;
    private float speed = 0.5f;
    private float currentPosY;
    private bool isUp;
    private Vector3 velocity = Vector3.zero;

    public void Start()
    {
        currentPosY = transform.position.y;
        isUp = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isUp)
            {
                currentPosY = CameraPosition1.position.y;
                isUp = false;
            }
            else
            {
                currentPosY = CameraPosition2.position.y;
                isUp = true;
            }
        }
        
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, currentPosY, transform.position.z), ref velocity, speed);
    }

}
