using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessGame : MonoBehaviour
{
    public int min = 1, max = 1000, liczba = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Witaj w grze!");
        Debug.Log("Wybierz liczbę od 1 do 1000.");
        Debug.Log(liczba + "?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W");
            min = liczba;
            liczba = (liczba + max) / 2;
            Debug.Log(liczba + "?");
        };
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S");
            max = liczba;
            liczba = (liczba + min) / 2;
            Debug.Log(liczba + "?");
        };
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter");
            Debug.Log("Hura!");
        };
    }
}
