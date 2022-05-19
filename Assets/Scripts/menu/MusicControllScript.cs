using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControllScript : MonoBehaviour
{
    public static MusicControllScript instanse;
    
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instanse == null)
        {
            instanse = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
