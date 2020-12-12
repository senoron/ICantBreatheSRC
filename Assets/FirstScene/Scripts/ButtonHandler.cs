using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    private Vector3 localScaleStart;

    private void Start()
    {
        localScaleStart = gameObject.transform.localScale;
    }

    private void OnMouseDown()
    {
        gameObject.transform.localScale *= 0.95f;
    }

    private void OnMouseUp() {
        switch (gameObject.name){
            case "GoToMain":
                startFadeOut();
                StartCoroutine("loadScene");
                break;
            case "Exit":
                 Application.Quit();
                 UnityEditor.EditorApplication.isPlaying = false;
            break;
        }

        gameObject.transform.localScale = localScaleStart;
    }

    void startFadeOut()
    {
        GameObject panel = GameObject.Find("Panel");
        panel.GetComponent<Animator>().SetTrigger("Fade in");
    }
    
    IEnumerator loadScene() {
        for(;;) {
            yield return new WaitForSeconds(2f);
            Application.LoadLevel("MiddleScene");
        }
    }
}
