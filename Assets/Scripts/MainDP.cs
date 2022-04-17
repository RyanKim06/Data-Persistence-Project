using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDP : MonoBehaviour
{
    public static MainDP instance;

    public Text bestScore;
    public Text bestPlayerName;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadBest();
    }

    public void NameEntered(string input)
    {
        MainDP.instance.bestPlayerName.text = input;
    }

    public void LoadBest()
    {

    }

    public void SaveBest()
    {

    }
}
