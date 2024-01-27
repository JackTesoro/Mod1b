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
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement 
        // changing direction
    }
}
