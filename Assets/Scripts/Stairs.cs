using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    EdgeCollider2D m_ObjectCollider;

    void Start()
    {
        m_ObjectCollider = GetComponent<EdgeCollider2D>();
        m_ObjectCollider.isTrigger = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            m_ObjectCollider.isTrigger = false;
        } else
        {
            m_ObjectCollider.isTrigger = true;
        }
    }
}
