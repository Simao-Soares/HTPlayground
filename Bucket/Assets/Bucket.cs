using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{



    void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Ball")
        {
            Debug.Log("Cesto!");
        }


        
    }
}
