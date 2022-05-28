using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //부딪힌 오브젝트 사망처리(적)
            collision.GetComponent<Enemy>().Ondie();

            Destroy(gameObject);
        }
    }
}
