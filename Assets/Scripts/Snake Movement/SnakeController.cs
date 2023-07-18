using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : Singleton<SnakeController>
{
    [SerializeField] float moveSpeed, steerStrength = 1f;

    [SerializeField] float bodySpeed = 5f;

    [SerializeField] int gapBetweenParts = 12;

    [SerializeField] Transform[] bodyParts_T;

    [SerializeField] List<Vector3> positionsHistory = new List<Vector3>();

    private void Update()
    {
        
        //Forward Movement
        transform.position += transform.forward * moveSpeed * Time.deltaTime;

        //Steering
        float direction = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * direction * steerStrength *  Time.deltaTime);

        positionsHistory.Insert(0, transform.position);

        int indexCounter = 1;
        foreach(Transform t in bodyParts_T)
        {

            Vector3 pos = positionsHistory[Mathf.Min(gapBetweenParts * indexCounter, positionsHistory.Count - 1)];
            Vector3 dir = pos - t.position;
            t.position += dir * Time.deltaTime * bodySpeed;
            t.LookAt(pos);
            indexCounter++;
        }

    }
}
