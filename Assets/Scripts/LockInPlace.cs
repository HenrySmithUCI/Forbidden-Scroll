using UnityEngine;
using System.Collections;

public class LockInPlace : MonoBehaviour
{
    public float delay;
    public float LockInTime;
    public float multiplyer;

    public AnimationCurve lockCurve;

    private float timer;
    private bool lockStarted;
    private bool locked;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
        timer = delay;
        locked = false;
        lockStarted = false;
    }
    
    void Update()
    {
        if (!locked)
        {
            if (!lockStarted)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    timer = 0;
                    lockStarted = true;
                    
                }
            }
            else
            {
                timer += Time.deltaTime;
                Vector3 pos = transform.position;
                pos.y = initialPosition.y + (lockCurve.Evaluate(timer / LockInTime) * multiplyer);
                if (timer / LockInTime >= 1)
                {
                    pos.y = initialPosition.y + lockCurve.Evaluate(1.0f) * multiplyer;
                    locked = true;
                }
                transform.position = pos;
            }
        }
    }
}
