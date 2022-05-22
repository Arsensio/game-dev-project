using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public GameObject endLevelUI;
    public Button nextLevel;
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
            int index = SceneManager.GetActiveScene().buildIndex;
            //if (Person.point > 90)
            //{
            //    button_txt.SetText("Next Level");
            // } else if (Person.point > 70)
            // {
            //    button_txt.SetText("Next Level");
            //} else
            if (Person.point > 20 - index * 2)
            {
                button_txt.SetText("Next Level");
                nextLevel.onClick.AddListener(nextOnClick);
            }  else 
            {
                button_txt.SetText("Restart");
                nextLevel.onClick.AddListener(restartOnClick);
            }
            txt.SetText("Score: " + Person.point.ToString());
            endLevelUI.SetActive(true);
        }
    }

    void nextOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void restartOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
