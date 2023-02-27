using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int playerScore = 0;
    int enemyScore = 0;
    int fishCollectables = 7;
    public TMP_Text playerScoreText;
    public TMP_Text enemyScoreText;
    public TMP_Text youWin;
    public TMP_Text youLose;
    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit, 1000))
            { 
                if (hit.collider.CompareTag("Ground"))
                {
                   player.nma.SetDestination(hit.point);
                }
                
            }
        }
        if (fishCollectables == 0)
        {

            Debug.Log("the fish are gone");
            if(playerScore > enemyScore)
            {
                youWin.alpha = 255;
            }
            
            else
            {
                youLose.alpha = 255;
            }
        }

     Debug.Log(fishCollectables.ToString());  
    }
    public void IncrementPlayerScore()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
    }

    public void IncrementEnemyScore()
    {
        enemyScore++;
        enemyScoreText.text = enemyScore.ToString();
    }
    
    public void DecreaseFishCollect()
    {
        fishCollectables--;
    }
}
