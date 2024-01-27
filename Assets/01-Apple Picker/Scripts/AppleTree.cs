using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Prefabe for instantiating apples
    public GameObject ApplePrefab;
    // speed at which the AppleTree moves
    public float speed = 1f;
    // distance where AppleTree turns around
    public float leftAndRightEdge = 10f;
    // chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.1f;
    // rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // dropping apples every second
        Invoke ("DropApple", 2f);
    }
    void DropApple(){
        GameObject apple = Instantiate<GameObject>(ApplePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }
    // Update is called once per frame
    void Update()
    {
        // basic movement 
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // changing direction
        if (pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed); // Move Right
        } else if (pos.x > leftAndRightEdge){
            speed = -Mathf.Abs(speed); // Move Left
    }
    }
    void FixedUpdate(){
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1; // Change Direction
        }
    }

}
