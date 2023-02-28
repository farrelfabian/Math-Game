using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{
    public static bool isCutsceneOn;
    public Animator camAnim;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PlayerMovement.movementSpeed = 0;
            isCutsceneOn = true;
            camAnim.SetBool("cutscene1", true);
            Invoke(nameof(StopCutscene), 2f);
        }
    }

    void StopCutscene()
    {
        PlayerMovement.movementSpeed = 9;
        isCutsceneOn = false;
        camAnim.SetBool("cutscene1", false);
        Destroy(gameObject);
    }
}
