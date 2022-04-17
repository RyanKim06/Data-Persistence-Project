using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MainDP : MonoBehaviour
{
    public static MainDP instance;

    public int bestScore;
    public string bestPlayerName;
    private string currentPlayerName;

    [System.Serializable]
    class SaveData
    {
        public string name;
        public int score;
    }

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

    public void NameEntered(GameObject nameInput)
    {
        instance.currentPlayerName = nameInput.GetComponent<InputField>().text;
        //Debug.Log(nameInput.GetComponent<InputField>().text);
        //Debug.Log(instance.currentPlayerName);
    }

    public void LoadBest()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScore = data.score;
            bestPlayerName = data.name;
        }
    }

    public void SaveBest(int score)
    {
        SaveData data = new SaveData();

        if(bestScore < score)
        {
            instance.bestScore = score;
            instance.bestPlayerName = currentPlayerName;

            data.score = bestScore;
            data.name = bestPlayerName;

            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        }
    }
}
