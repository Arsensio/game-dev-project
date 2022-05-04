using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public GameObject person;
    public GameObject person2;

    public void Start()
    {
        person.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // StartCoroutine(ExampleCoroutine());
        bool change = Input.anyKey;
        person.SetActive(change);
        person2.SetActive(!change);
    }
}
