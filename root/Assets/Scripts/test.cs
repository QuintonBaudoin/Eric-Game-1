using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(theLevel);
        }
    }

    public string theLevel;
}
