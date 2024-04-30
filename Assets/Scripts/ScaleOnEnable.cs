using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnEnable : MonoBehaviour
{
    public Vector3 scaleFrom;
    public Vector3 scaleTo;
    public float timeToScale = 0.25f;
    public float timeWait = 4.5f;


    private void OnEnable()
    {
        StartCoroutine(ScaleObj());
    }

    IEnumerator ScaleObj()
    {
        float timer = 0f;
        transform.localScale = scaleFrom;

        while (timer < timeToScale)
        {
            timer+= Time.deltaTime;
            transform.localScale = Vector3.Min(scaleTo * timer / timeToScale, scaleTo);

            yield return null;
        }

        yield return new WaitForSeconds(timeWait);

        while (timer > 0)
        {
            timer -= Time.deltaTime;
            transform.localScale = Vector3.Max(scaleTo * timer / timeToScale, scaleFrom);

            yield return null;
        }
    }
}
