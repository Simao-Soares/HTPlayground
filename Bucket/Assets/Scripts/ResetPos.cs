using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    Vector3 originalPos;
    
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        //simpler alternative: originalPos = gameObject.transform.position;
    
    }
    public void Reset()
    {
        gameObject.transform.position = originalPos;
    }
}
