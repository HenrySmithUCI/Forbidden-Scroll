using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PressKeyToWin : MonoBehaviour {
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.ScrollLock))
        {
            SceneManager.LoadScene("GameWinScene");
        }
    }
}
