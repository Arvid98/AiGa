using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private EnemyPathfindingMovment pathfindingMovment;
    private Vector3 startingPosition;
    private Vector3 roamPosition;
  

    private void Awake()
    {
        pathfindingMovment = GetComponent<EnemyPathfindingMovment>();
    }

    void Start()
    {
        startingPosition = transform.position;
    }

    private void Update()
    {
        pathfindingMovment.MoveTo(roamPosition);
        float reachedPositionDistance = 1f;
        if(Vector3.Distance(transform.position, roamPosition) < reachedPositionDistance)
        {
            roamPosition = GetRoamingPosition();
        }
    }

    private Vector3 GetRoamingPosition()
    {
        return startingPosition + 
            new Vector3(UnityEngine.Random.Range(-1f, -1f), UnityEngine.Random.Range(-1f, 1f)).normalized
            * Random.Range(10f, 70f);
    }

    private void FindTarget()
    {
        float targetRange = 50f;
        //if (Vector3.Distance(transform.position, Player.Instance.GetPosition()) < targetRange)
        //{

        //}
    }

}
