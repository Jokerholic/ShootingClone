using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private int damage = 1; //적 공격력
    [SerializeField]
    private int scorePoint = 100; //적 처치 시 획득 점수
    private PlayerController playerController; //플레이어의 점수에 접근하기 위해

    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().TakeDamage(damage);

            Ondie();
        }
    }

    public void Ondie()
    {
        playerController.Score += scorePoint;
        Destroy(gameObject);

    }
}
