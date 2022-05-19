using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Person : MonoBehaviour
{
    public GameObject person;
    public GameObject person2;
    public Transform startPosition;
    public TMP_Text txt;

    public static int point = 0;

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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Point")
        {
            if (collision.gameObject.layer == 3)
            {
                point += 1;
            }
            else
            {
                point -= 1;
            }
            Destroy(collision.gameObject);
            txt.SetText(point.ToString());
        }
        Debug.Log(point);
    }

    void respawn()
    {
        this.gameObject.transform.position = new Vector3(startPosition.position.x, startPosition.position.y, 0);
    }
}
