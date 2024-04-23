using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemTrash : MonoBehaviour
{
    public UnityEvent destroyEvents;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag != "Trash")
            return;

        Destroy(collider.gameObject);
        destroyEvents.Invoke();
    }
}
