using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallProtection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FallBlock fallBlock = other.GetComponent<FallBlock>();
        if (!fallBlock)
            return;

        Vector3 newPos = Camera.main.transform.position + (Vector3.up * 0.5f) + (Camera.main.transform.forward * 1.5f);
        other.transform.position = newPos;
    }
}
