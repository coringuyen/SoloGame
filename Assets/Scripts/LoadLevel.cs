using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

    public int level;

    void loadScene(int level)
    {
        Application.LoadLevel(level);
    }

    void OnTriggerEnter(Collider player)
    {
        if(player)
        {
            loadScene(level);
        }
    }
}
