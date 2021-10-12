using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuChange : MonoBehaviour
{
    private void Update()
    {
        string scenename = SceneManager.GetActiveScene().name;
        if (Input.GetKey(KeyCode.Escape))
        {
            if (scenename != "ProblemSolving10")
            {
                SceneManager.LoadScene("ProblemSolving10");
            }
            else
            {
                Application.Quit();
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void gantiscene(string scene){
        SceneManager.LoadScene(scene);
    }

    public void exitgame(){
        Application.Quit();

    }

    
    
}
