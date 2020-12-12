using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    private void OnMouseUp() {
        switch (gameObject.name){
            case "GoToMain":
                Application.LoadLevel("Main");
            break;
            case "Exit":
                 Application.Quit();
                 UnityEditor.EditorApplication.isPlaying = false;
            break;
        }
            
    }
}
