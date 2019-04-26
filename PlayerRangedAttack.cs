using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRangedAttack : MonoBehaviour
{
    private float attackCooldown;
    public float startAttackCooldown;
    public LayerMask findEnemy;
    public int damage;
    public Animator animator;
    public GameObject projectile;


    void Update()
    {
        if (attackCooldown <= 0)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                animator.SetTrigger("Shoot");
            }
        }
    }
}
