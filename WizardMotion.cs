using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardMotion : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        //������ �������� ���������� velX � velY �������� �������� ������������� ���������
        animator.SetFloat("VelX", Input.GetAxis("Horizontal"), 0.1f, Time.deltaTime);
        animator.SetFloat("VelY", Input.GetAxis("Vertical"), 0.1f, Time.deltaTime);
    }
}
