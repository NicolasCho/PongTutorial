using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject ball;

    public GameObject player1Paddle;
    public GameObject player1Goal;

    public GameObject player2Paddle;
    public GameObject player2Goal;

    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;
    
    public void Player1Scored(){
        Player1Score++;
        if(Player1Score > 9){
            SceneManager.LoadScene("Menu");
        }
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }
    public void Player2Scored(){
        Player2Score++;
        if(Player2Score > 9){
            SceneManager.LoadScene("Menu");
        }
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<PlayerMovement>().Reset();
        player2Paddle.GetComponent<PlayerMovement>().Reset();
    }
}
