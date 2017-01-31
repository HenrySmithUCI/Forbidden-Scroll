using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PressKeyToWin : MonoBehaviour {
    void Update ()
    {
        if (Input.GetKey(KeyCode.ScrollLock))
        {
            goToWinScene();
        }
    }

    public void goToWinScene()
    {
        SceneManager.LoadScene("GameWinScene");
    }
}
