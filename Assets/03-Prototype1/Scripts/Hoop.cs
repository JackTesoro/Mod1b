using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Score.instance.AddPoint();
    }
}
