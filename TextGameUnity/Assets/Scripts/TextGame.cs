using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextGame : MonoBehaviour
{
    TextGame textUI;

    void AudioLoader()
    {
        GameObject gameObject = GameObject.Find("Canvas");
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    int SceneChecker()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MainMenu")
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    void TextLoader ()
    {
        Text textUI;
        textUI = GetComponent<Text>();

        if (SceneChecker() == 0)
        {
            textUI.text =    "Znajdujesz się w ciemnym domu \n" +
                             "Nie ma w nim żadnego światła \n" +
                             "A ty szukasz wyjścia z tej ciemności, dlatego dotknij ENTER \n";
        }
        else
        {
            textUI.text = "Opis lokalizacji";
        }
    }

    void Start ()
    {
        SceneChecker();
        TextLoader();
        AudioLoader();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("Levels");
    }
}
