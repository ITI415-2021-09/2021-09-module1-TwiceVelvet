using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]

    //Prefab for instantiating apples
    public GameObject applePrefab;

    //Speed at which the AppleTree moves
    public float speed = 1f;

    //Distance where AppleTree turns around

    public float leftAndRightEdge = 20;

    //Chance that the AppleTree will change di
    public float chanceToChangeDirections = .1f;

    //Rate at which Apples will be instantiated 
    public float secondsBetweenAppleDrops = .2f;

    void Start (){
        //Dropping apples every second
        Invoke( "DropApple", .5f );        
    }

    void DropApple() {                         
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    void Update(){
        //Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //changing direction

        if (pos.x < -leftAndRightEdge){
            speed = Mathf.Abs(speed); //move right
        } else if (pos.x > leftAndRightEdge){
            speed = -Mathf.Abs(speed); //Move left
        }
    }

    void FixedUpdate() {
        //Changing direction randomly is now time-based because of FixedUpdate()
        if (Random.value < chanceToChangeDirections){
            speed *= -1; //Change direction
        }
    }
}