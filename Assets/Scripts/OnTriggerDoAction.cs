using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerDoAction : MonoBehaviour
{
    public UnityEvent onTriggerAction;

    void OnTriggerEnter(Collider col)
    {
        Rigidbody rig = col.GetComponent<Rigidbody>();
        if (!rig || rig.isKinematic)
            return;

        onTriggerAction.Invoke();
    }
}
