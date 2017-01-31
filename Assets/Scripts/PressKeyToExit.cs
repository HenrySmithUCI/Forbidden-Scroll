using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PressKeyToExit : MonoBehaviour {
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
