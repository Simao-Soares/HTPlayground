using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

 

public class Bucket : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;



    private void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Ball")
        {
            Debug.Log("Cesto!");
            if (collisionInfo.collider.name == "Ball1"){
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                this.scoreTrigger.Invoke(eventData);
            }

        }


        
    }
}
