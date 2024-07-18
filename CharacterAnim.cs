using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    int isWalkingHash, isRunningHash, isJumpingHash, isAttackingHash;

    void Start()
    {
        //�������� id ������ ���������� � ��� �� ��������� ����� �� �� �����
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");
        isAttackingHash = Animator.StringToHash("isAttacking");
    }


    void Update()
    {
        //�������� �� id ���������� �� ������ ��������
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isJumping = animator.GetBool(isJumpingHash);
        bool isAttacking = animator.GetBool(isAttackingHash);

        //�������� ������ �������� ���������� �������� ����� ������
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool jumpPressed = Input.GetKey("space");
        bool attackClick = Input.GetMouseButtonDown(0);

        //���� ����� �� ��� � ������ ������� W, �� �������� �������� ������
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        //���� ����� ��� � �� ������ ������� W, �� ��������� �������� ������
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        //���� ����� �� ����� � ������ ����� ���� � W, �� �������� �������� ����
        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        //���� ����� ����� � �� ����� ����� ���� ��� W, �� ��������� �������� ����
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }

        //���� ����� �� ������� � ����� ������, �� �������� �������� ������
        if (!isJumping && jumpPressed)
        {
            animator.SetBool("isJumping", true);
        }

        //���� ����� ������� � �� ����� ������, �� ��������� �������� ������
        if (isJumping && !jumpPressed)
        {
            animator.SetBool("isJumping", false);
        }

        //���� ����� �� ������� � ����� ����� ������ ����, �� �������� �������� �����
        if (!isAttacking && attackClick)
        {
            animator.SetBool("isAttacking", true);
        }

        //���� ����� ������� � �� ����� ����� ������ ����, �� ��������� �������� �����
        if (isAttacking && !attackClick)
        {
            animator.SetBool("isAttacking", false);
        }
    }
}
