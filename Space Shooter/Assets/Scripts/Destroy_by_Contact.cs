using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_by_Contact : MonoBehaviour
{

    public int scoreValue;

   private GameController gameController;
  

    private void Start()
    {

      GameObject GameControllerObject = GameObject.FindWithTag("GameController");
        if(GameControllerObject !=null)
        {
            gameController = GameControllerObject.GetComponent<GameController>();
        }

        if(GameControllerObject == null)
        {
            Debug.Log("Скрипт 'GameController' не найден");
        }
      
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {
            
            Destroy(other.gameObject);

            Destroy(gameObject);

            gameController.GameOver();
            

        }

        if (other.tag == "Blaster")
        { 
            
            Destroy(other.gameObject);

            Destroy(gameObject);

          gameController.AddScore(scoreValue);
           
        }

    }

}
