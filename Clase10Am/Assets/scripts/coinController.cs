using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Moneda");
        gameObject.SetActive(false);
        //Destroy(gameObject);
        if (SceneManager.GetActiveScene().name == "Nivel_1")
        {
            SceneManager.LoadScene("Nivel_2");
        }
        else
        {
            SceneManager.LoadScene("Nivel_1");
        }
    }
}
