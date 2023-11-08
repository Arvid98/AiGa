using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfindingMovment : MonoBehaviour
{
    private const float SPEED = 30f;

    //private EnemyMain enemyMain;
    private List<Vector3> pathVectorList;
    private int currentpathIndex;
    private float pathfindingTimer;
    private Vector3 moveDir;
    private Vector3 lastMoveDir;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveTo(Vector3 targetPosition)
    {
        SetTargetPosition(targetPosition);
    }

    private void SetTargetPosition(Vector3 targetPosition)
    {
        throw new NotImplementedException();
    }
}
