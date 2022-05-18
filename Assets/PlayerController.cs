using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private StageData   stageData;
    private Movement2D  movement2D;
    [SerializeField]
    private KeyCode     keyCodeAttack = KeyCode.Space;
    private Weapon      weapon;

    private int         score;
    public int          Score
    {
        //점수가 음수가 되지 않도p
        set => score = Mathf.Max(0, value);
        get => score;
    }

    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
        weapon     = GetComponent<Weapon>();
    }

    // Update is called once per frame
    private void Update()
    {
        //방향키를 눌러 이동 방향 설정
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement2D.MoveTo(new Vector3(x, y, 0));

        //공격 키를 Down/Up으로 공격 시작/종료
        if (Input.GetKeyDown(keyCodeAttack))
        {
            weapon.StartFiring();
        }
        else if (Input.GetKeyUp(keyCodeAttack))
        {
            weapon.StopFiring();
        }
    }

    private void LateUpdate()
    {
        //플레이어 캐릭터가 화면 범위 바깥으로 나가지 못하도록 함
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }
    // Mathf.Clamp(value, min, max): value가 min보다 작으면 min 반환, max보다 크면 max 반환
}
