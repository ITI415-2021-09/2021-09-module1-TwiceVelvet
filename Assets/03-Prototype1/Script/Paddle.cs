using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Camera mainCamera;
    float leftMax = 70;
    float rightMax = 560;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>(); //setting main camera
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }

    void Movement(){
        float maxMovement = Mathf.Clamp(Input.mousePosition.x,leftMax,rightMax);
        float worldxPos = mainCamera.ScreenToWorldPoint(new Vector3(maxMovement,0,0)).x;
        //Paddle moves w/ mouse in relation to main camera
        this.transform.position = new Vector3(worldxPos, -17, 0);
    }
}
