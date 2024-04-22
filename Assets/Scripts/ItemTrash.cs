using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrash : MonoBehaviour
{
    public ParticleSystem destroyFX;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag != "Trash")
            return;

        Destroy(collider.gameObject);
        destroyFX.Play();
    }
}
