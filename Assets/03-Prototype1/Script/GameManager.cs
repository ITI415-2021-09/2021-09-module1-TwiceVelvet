using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class GameManager : MonoBehaviour
{
    public Ball initialBall; //Initialize ball
    public Ball ballPrefab; //Reference to prefab

    public Paddle paddle; //So paddle can be found

    public static bool startGame;
    public static bool gameStarted;

    public Text endScreen;
    public int count; 
 
    // Start is called before the first frame update
    void Start()
    {
       
        InitializeBall();
    }

    // Update is called once per frame
    void Update()
    {
        youWin();
        PreStartGame();
        youLose();
    }
    
    void PreStartGame(){
        
        Vector3 paddlePos = paddle.gameObject.transform.position; //So that location of ball can be placed
        Vector3 ballPos = new Vector3(paddlePos.x, paddlePos.y + .25f, 0); //Value for ball position

        if (Input.GetMouseButtonDown(0)){
            startGame = true;
        }

        if (!startGame){
            initialBall.transform.position = ballPos;
        }
    }
    void youWin(){
        GameObject[] blocks;
        blocks = GameObject.FindGameObjectsWithTag("block");
        count = blocks.Length;

        if(count == 0){
            endScreen.text = "YOU WIN";
        }

    }

    void youLose(){
        if(initialBall == null){
            endScreen.text = "YOU LOSE";
        }
    }
    void InitializeBall(){

        Vector3 paddlePos = paddle.gameObject.transform.position; //So that location of ball can be placed
        Vector3 ballPos = new Vector3(paddlePos.x, paddlePos.y + .25f, 0); //Value for ball position
        initialBall = Instantiate(ballPrefab, ballPos, Quaternion.identity);

    }
}
