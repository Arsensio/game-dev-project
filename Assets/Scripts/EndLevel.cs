using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject endMenuUI;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            
            Time.timeScale = 0f;
            if (Person.point > 90)
            {
                
            } else if (Person.point > 70)
            {
                
            } else if (Person.point > 50)
            {
                
            }  else 
            {
                
            }
            endMenuUI.SetActive(true);
        }
    }
}
