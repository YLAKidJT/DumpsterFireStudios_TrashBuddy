using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{ 
public float interpVelocity;
public float minDistance;
public float followDistance;
    public float shiftSpeed;
public GameObject target;
public Vector3 offset;
    public Vector3 targetOffset;
Vector3 targetPos;
// Use this for initialization
void Start()
{
    targetPos = transform.position;
}

// Update is called once per frame
void Update()
{
        if (target.transform.localScale.x > 0)
        {
            targetOffset = new Vector3(5, 0, -80);
        }
        else
        {
            targetOffset = new Vector3(-5, 0, -80);
        }

        offset = Vector3.Lerp(offset, targetOffset, Time.deltaTime*shiftSpeed);

        transform.position = target.transform.position + offset;


    }
}
