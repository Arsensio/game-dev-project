using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndLevel : MonoBehaviour
{
    public GameObject endLevelUI;
    public TMP_Text button_txt;
    public TMP_Text txt;

    public void Start()
    {
        endLevelUI.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            
            Time.timeScale = 0f;
            //if (Person.point > 90)
            //{
            //    button_txt.SetText("Next Level");
           // } else if (Person.point > 70)
           // {
            //    button_txt.SetText("Next Level");
            //} else
            if (Person.point > 20)
            {
                button_txt.SetText("Next Level");
            }  else 
            {
                button_txt.SetText("Restart");
            }
            txt.SetText("Score: " + Person.point.ToString());
            endLevelUI.SetActive(true);
        }
    }
}
