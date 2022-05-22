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
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput > 0.1f)
        {
            m_ObjectCollider.isTrigger = false;
        } else
        {
            m_ObjectCollider.isTrigger = true;
        }
    }
}
