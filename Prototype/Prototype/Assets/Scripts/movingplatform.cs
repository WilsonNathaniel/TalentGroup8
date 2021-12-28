using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    [SerializeField] private Transform m_pos1; //pos1
    [SerializeField] private Transform m_pos2; //pos2
    [SerializeField] private float speed = 5f; //movespeed
    [SerializeField] private Transform platform; //object platformnya
    private Transform goal;
    private int nextgoal;

    private void Start()
    {
        goal = m_pos2;
        nextgoal = 1;
    }
    void Update()
    {
        platform.position = Vector2.MoveTowards(platform.position, goal.position, Time.deltaTime * speed);

        if(Vector2.Distance(platform.position, goal.position) < 0.1f)
        {
            if(nextgoal == 1)
            {
                goal = m_pos1;
                nextgoal = 2;
            }
            else if(nextgoal == 2)
            {
                goal = m_pos2;
                nextgoal = 1;
            }
        }
    }
}
