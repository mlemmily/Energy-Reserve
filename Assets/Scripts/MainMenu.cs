using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject MenuStart;
    public GameObject MenuExplain;
    public void PlayGame()
    {
        StartCoroutine(SceneManagerLoad());
        MenuStart.SetActive(false);
        
    }

    IEnumerator SceneManagerLoad()
    {
        MenuExplain.SetActive(true);
        yield return new WaitForSeconds(25f);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
