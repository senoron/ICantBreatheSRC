using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
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
