using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball initialBall; //Initialize ball
    public Ball ballPrefab; //Reference to prefab

    public Paddle paddle; //So paddle can be found
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InitializeBall();
    }

    void InitializeBall(){
        Vector3 paddlePos = paddle.gameObject.transform.position; //So that location of ball can be placed
        Vector3 ballPos = new Vector3(paddlePos.x, paddlePos.y + .25f, 0); //Value for ball position
        initialBall = Instantiate(ballPrefab, ballPos, Quaternion.identity);

    }
}
