using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int playerScore = 0;
    int enemyScore = 0;
    public TMP_Text playerScoreText;
    public TMP_Text enemyScoreText;
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

}
