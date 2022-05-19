using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public GameObject person;
    public GameObject person2;
    public Transform startPosition;

    public static int point;


    public void Start()
    {
        person2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // StartCoroutine(ExampleCoroutine());
        //bool change = Input.anyKey;
        //person.SetActive(change);
        //person2.SetActive(!change);
        if (Input.GetKeyDown(KeyCode.K))
        {
            respawn();
        }
    }

    void respawn()
    {
        this.gameObject.transform.position = new Vector3(startPosition.position.x, startPosition.position.y, 0);
    }
}
