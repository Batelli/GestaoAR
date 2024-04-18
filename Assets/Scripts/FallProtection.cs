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

        Vector3 newPos = Camera.main.transform.position + (Vector3.up * 2) + (Camera.main.transform.forward * 3);
        other.transform.position = newPos;
    }
}
