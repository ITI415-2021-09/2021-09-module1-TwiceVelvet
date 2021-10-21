using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winlose : MonoBehaviour {
    [Header("Set in Inspector")]

    //Speed at which the AppleTree moves
    public float speed = 50000f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge = 20;

    //Chance that the AppleTree will change di
    public float chanceToChangeDirections = .01f;

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
            speed *= 1; //Change direction
        }
    }

}
