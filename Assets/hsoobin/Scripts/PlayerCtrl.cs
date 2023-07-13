using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 vector;

    const float moveSpeed = 5.0f; // 플레이어 이동 속도
    private int playerHP = 100;

    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        clickCheck();
    }

    void PlayerMove() // 플레이어 이동 함수
    {
        vector.x = Input.GetAxisRaw("Horizontal"); // 좌우 이동(A, D키)
        vector.y = Input.GetAxisRaw("Vertical"); // 상하 이동(W, S키)

        rb.velocity = vector * moveSpeed; // 플레이어 이동
    }

    void clickCheck()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(playerHP > 0)
            {
                playerHP -= 10;
            }

            Debug.Log(playerHP);
        }
    }

}
