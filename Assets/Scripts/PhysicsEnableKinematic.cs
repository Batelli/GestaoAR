using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEnableKinematic : MonoBehaviour
{
    Rigidbody rig;
    float timer = 0;


    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rig.isKinematic)
            return;


        timer += Time.deltaTime;
        if (timer > 2 && Mathf.Abs(rig.velocity.magnitude) < 0.001f)
            rig.isKinematic = true;
    }

    public void TurnKinematicOff()
    {
        timer = 0;
        rig.isKinematic = false;
    }
}
