using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongManager : MonoBehaviour
{
    public static PingPongManager Instance { get; private set; }
    public GameObject[] balls;
    Vector3[] positions;

    

    private void Awake()
    {
        //Singleton
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;

        positions = new Vector3[balls.Length];
        for (int i = 0; i < balls.Length; i++)
            positions[i] = balls[i].transform.position;
    }

    public void CreateNewBalls()
    {
        for (int i = 0; i < balls.Length; i++)
        {
            Destroy(balls[i]);
            balls[i] = Instantiate(Resources.Load<GameObject>("PingPongBall"), positions[i], Quaternion.identity);
            balls[i].transform.parent = transform;
        }
    }
}
