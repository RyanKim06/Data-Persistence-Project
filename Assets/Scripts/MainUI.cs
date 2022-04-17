using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public GameObject bestScoreText;

    private void Awake()
    {
        bestScoreText.GetComponent<Text>().text =
            $"BEST SCORE | {MainDP.instance.bestPlayerName} | {MainDP.instance.bestScore}";
    }
}
