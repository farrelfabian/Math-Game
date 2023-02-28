using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSign : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("MAdd"))
        {
            SceneManager.LoadScene("MathAdd");
        }

        if(collision.gameObject.CompareTag("MSub"))
        {
            SceneManager.LoadScene("MathSub");
        }

        if(collision.gameObject.CompareTag("MMult"))
        {
            SceneManager.LoadScene("MathMult");
        }

        if(collision.gameObject.CompareTag("MDiv"))
        {
            SceneManager.LoadScene("MathDiv");
        }
    }
}
