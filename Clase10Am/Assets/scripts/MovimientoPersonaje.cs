using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(3.5f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-3.5f * Time.deltaTime, 0, 0);
        }
    }
}
