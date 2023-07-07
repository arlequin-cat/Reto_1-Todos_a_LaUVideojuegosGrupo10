using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    public void pausa()
    {
        Debug.Log("pausa");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void continuar()
    {
        Debug.Log("continuar");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
