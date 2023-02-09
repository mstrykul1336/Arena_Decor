using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowItemBeh : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Oh no! You ate too much! Mass increased, size increased and speed decreased!");
        }
    }
}
