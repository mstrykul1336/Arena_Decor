using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItemBeh : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Brrvvvroom! You gained speed!");
        }
    }
}
