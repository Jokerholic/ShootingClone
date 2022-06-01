using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private int damage = 1; //적 공격력
    [SerializeField]
    private int scorePoint = 100; //적 처치 시 획득 점수
    [SerializeField]
    private GameObject explosionPrefab; // 폭발 효과
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
        //플레이어의 점수를 scorePoint만큼 증가시킨다
        playerController.Score += scorePoint;
        //폭발 이펙트 생성
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        //적 오브젝트 삭제
        Destroy(gameObject);

    }
}
