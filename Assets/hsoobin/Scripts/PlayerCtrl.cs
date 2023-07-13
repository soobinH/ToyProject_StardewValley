using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 vector;

    const float moveSpeed = 5.0f; // �÷��̾� �̵� �ӵ�
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

    void PlayerMove() // �÷��̾� �̵� �Լ�
    {
        vector.x = Input.GetAxisRaw("Horizontal"); // �¿� �̵�(A, DŰ)
        vector.y = Input.GetAxisRaw("Vertical"); // ���� �̵�(W, SŰ)

        rb.velocity = vector * moveSpeed; // �÷��̾� �̵�
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
