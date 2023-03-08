using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int playerScore = 0;
    int coins;
    public TMP_Text scoreText;
    public TMP_Text coinText;
    public TMP_Text winDisplay;
    public PlayerController player;
    public Object PizzaSteve;
    public Transform PizzaPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin").Length;

        coinText.text = coins.ToString(); //+ pc.score;

        if (GameObject.FindGameObjectsWithTag("Coin").Length <= 0)
        {
                winDisplay.text = "You made it! You win!";
                Instantiate(PizzaSteve, PizzaPos, PizzaPos);
        }

    }

    // This function can be called from other scripts. For example, inside of the
    // PlayerController's OnTriggerEnter function. But remember, the PlayerController
    // would need to have a reference to this GameManager object. This is most
    // easily accomplished by creating a 'public GameManager gm;' in PlayerController
    // and dragging and dropping the GameManager object into the inspector.
    public void IncrementScore()
    {
        Debug.Log("Incremented Score!");
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }


    // This keeps track of the enemy's score. 
    public void IncrementEnemyScore()
    {
        playerScore = playerScore - 1;
        scoreText.text = playerScore.ToString();
        Debug.Log("Hit an Enemy!");
    }
}
