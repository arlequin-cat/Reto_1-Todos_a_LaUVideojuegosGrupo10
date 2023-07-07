using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public int scene;
    public GameObject pauseMenu;

    public void home()
    {
        Debug.Log("home");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);

    }
}
