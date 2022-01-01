using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    public int Rainbow;

    public void Update()
    {
       if (Input.GetButton("Enter"))
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);

        }
    }

          private void Start()

{

        Update();

  }
}
