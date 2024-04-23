using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerDoAction : MonoBehaviour
{
    public UnityEvent onTriggerAction;

    void OnTriggerEnter(Collider col)
    {
        onTriggerAction.Invoke();
    }
}
