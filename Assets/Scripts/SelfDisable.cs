using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDisable : MonoBehaviour
{
    public float selfDisableTime = 1;

    private void OnEnable()
    {
        StartCoroutine(SelfDeactivate());
    }

    IEnumerator SelfDeactivate()
    {
        yield return new WaitForSeconds(selfDisableTime);
        gameObject.SetActive(false);
    }
}
