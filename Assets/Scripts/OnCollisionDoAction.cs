using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionDoAction : MonoBehaviour
{
    public UnityEvent onTriggerAction;

    void OnCollisionEnter(Collision collision)
    {
        onTriggerAction.Invoke();
    }
}
