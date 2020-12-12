using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Playbutton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
