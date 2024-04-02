using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class army : MonoBehaviour
{
    [Header("army¡§∫∏")]
    [SerializeField] float Speed = 1f;
    [SerializeField] float Hp = 10f;
    [SerializeField] float damage = 3f;

    Rigidbody2D rigid;
    BoxCollider2D boxCollider2D;
    Animator anim;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Speed = 0;
        offense();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
        anim.SetBool("walk", Speed == 1);
    }
    private void offense()
    {
        anim.SetBool("contact", Speed == 0);
    }

    private void AttackEnemyTower()
    {
        
    }
}
