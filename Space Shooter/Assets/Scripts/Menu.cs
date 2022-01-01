using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void StartGame()
    {

                SceneManager.LoadScene("Game Scene", LoadSceneMode.Single);

    }

    public void ExitGame()
    {

        Debug.Log("Игра закрылась");
        Application.Quit();

    }

}
