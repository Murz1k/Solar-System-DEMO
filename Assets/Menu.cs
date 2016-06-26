using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour
{

    public int window;

    void Start()
    {
        window = 1;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width - 180, Screen.height - 30, 200, 100), "Created by Maxim Zakharov");
        GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200));
        if (window == 1)
        {
            if (GUI.Button(new Rect(10, 30, 180, 30), "Запуск"))
            {
                SceneManager.LoadScene(1);
            }
            if (GUI.Button(new Rect(10, 70, 180, 30), "Выход"))
            {
                window = 2;
            }
        }
        if (window == 2)
        {
            GUI.Label(new Rect(50, 10, 180, 30), "Вы точно хотите выйти?");
            if (GUI.Button(new Rect(10, 40, 180, 30), "Да"))
            {
                Application.Quit();
            }
            if (GUI.Button(new Rect(10, 80, 180, 30), "Нет"))
            {
                window = 1;
            }
        }
        GUI.EndGroup();
    }
}