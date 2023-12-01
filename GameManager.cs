using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Gameobjects to set")]
    public GameObject BeePrefab;
    public GameObject startingpos;
    public GameObject GameOverScreen;
    public GameObject RespawningText;
    public GameObject LivesCounter; //STILL NEEDS TO BE DONE, FIND LivesCounter.Text!!!!! 
    public Scene nextScene;

    [Header("Integers to set")]
    public int NumBalloons = 100; //Change every scene
    public int lives = 3;




    void Update()
    {
        if (NumBalloons == 0)
        {
            SceneManager.LoadScene("nextScene");
        }
    }







    //Called on Bee.cs for hitting barrier
    public void Death()
    {
        BeePrefab.SetActive(false);
        lives -= 1;
        if (lives > 0)
        {
            RespawningText.SetActive(true);
            Invoke("Revive", 2);
        }
        if (lives == 0)
        {
            GameOverScreen.SetActive(true);
        }
     
    }
    public void Revive()
    {
        BeePrefab.transform.position = startingpos.transform.position;
        RespawningText.SetActive(false);
        BeePrefab.SetActive(true);
    }
}
