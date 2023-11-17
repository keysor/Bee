using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Inscribed")]
    public int lives = 3;
    public GameObject BeePrefab;
    public GameObject startingpos;
    public int NumBalloons = 100; //Change every scene


    void Update()
    {
        if (NumBalloons == 0)
        {
            // ADD SCENE MANAGER STUFF
        }
    }

    public void Death()
    {
        BeePrefab.transform.position = startingpos.transform.position;
        lives -= 1;
    }
    
}
