using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextGame : MonoBehaviour
{
    enum Levels
    {
        MainMenu, Morgue, Street, Bar,
    }

    Levels levels;

    void AudioLoader()
    {
        GameObject gameObject = GameObject.Find("Text");
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    void SceneChecker()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MainMenu")
        {
            levels = Levels.MainMenu;
        }
        else if (scene.name == "Morgue")
        {
            levels = Levels.Morgue;
        }
        else if (scene.name == "Street")
        {
            levels = Levels.Street;
        }
        else if (scene.name == "Bar")
        {
            levels = Levels.Bar;
        }
    }

    void TextLoader ()
    {
        Text textUI;
        textUI = GetComponent<Text>();

        if (levels == Levels.MainMenu)
        {
            textUI.text =    "Znajdujesz się w ciemnym domu \n" +
                             "Nie ma w nim żadnego światła \n" +
                             "A ty szukasz wyjścia z tej ciemności, dlatego dotknij ENTER \n";
        }
        else if (levels == Levels.Morgue)
        {
            textUI.text = "Jesteś w kostnicy.\n" +
                          "A właściwie na zewnątrz \n" +
                          "Możesz wejść do miasteczka, dlatego dotknij S \n";
        }
        else if (levels == Levels.Street)
        {
            textUI.text = "Jesteś w miasteczku złożonym z ulic i domków." +
                          "Przytłacza cię nadmiar budynków i chcesz się napić \n" +
                          "Znajdujesz więc bar, dlatego dotknij W \n";
        }
        else if (levels == Levels.Bar)
        {
            textUI.text = "Przyszedłeś się napić, a tu nie ma barmana." +
                          "Nie możesz nic kupić, ale nie chcesz nic kraść \n" +
                          "Możesz wrócić do miasteczka, dlatego dotknij S \n";
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
        {
            SceneManager.LoadScene("Morgue");
        //    levels = Levels.Morgue;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene("Bar");
        //    levels = Levels.Bar;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Street");
        //    levels = Levels.Street;
        }
    }
}
