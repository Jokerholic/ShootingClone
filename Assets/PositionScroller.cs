using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScroller : MonoBehaviour
{
    [SerializeField]
    private Transform   target; // 현재 게임에서는 두 개의 배경이 서로 타겟
    [SerializeField]
    private float       scrollRange = 9.9f;
    [SerializeField]
    private float       moveSpeed = 3.0f;
    [SerializeField]
    private Vector3     moveDirection = Vector3.down;

    // Update is called once per frame
    void Update()
    {
        // 배경이 moveDirection 방향으로 moveSpeed의 속도로 이/
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        if (transform.position.y <= -scrollRange)
        {
            transform.position = target.position + Vector3.up * scrollRange;
        }
    }
}
