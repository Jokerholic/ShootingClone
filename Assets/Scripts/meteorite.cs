using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorite : MonoBehaviour
{

    [SerializeField]
    private int damage = 5;
    [SerializeField]
    private GameObject explosionPrefab; // 폭발 효과


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            //폭발 이펙트 생성
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            //운석 삭제
            Destroy(gameObject);
        }
    }
}
