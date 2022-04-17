using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public GameObject bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        if(MainDP.instance != null)
        {
            bestScoreText.GetComponent<Text>().text = 
                $"BEST SCORE | {MainDP.instance.bestPlayerName} | {MainDP.instance.bestScore}";
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        //MainDP.instance.SaveBest();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }
}
