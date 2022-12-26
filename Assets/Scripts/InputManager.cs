using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{   
    public string input;

    public static InputManager InputInstance;

    private void Awake() {
        if (InputInstance != null){

            Destroy(gameObject);
            return;

        }

        InputInstance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void StoreName(string s){
        input = s;

        //Debug.Log(s);

        //MainManager.Instance.playerScores.Add(s, 0);

    }

    public void LoadMainScene(){

        SceneManager.LoadScene(1);

    }
}
