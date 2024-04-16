using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MushroomMonster : MonoBehaviour
{
    [Header("MushroomMonster Á¤º¸")]
    [SerializeField] float Speed = 1f;
    [SerializeField] float Hp = 30f;
    [SerializeField] float damage = 2f;
    [SerializeField] float damagetime = 0.5f;
    Collider2D col;
    float timer;
    bool checksoldier = false;


    Animator anim;
    private void Awake()
    {

        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == Tool.GetGameTag(GameTag.soldier))
        {
            col = collider2D;
            Speed = 0;
            checksoldier = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.tag == Tool.GetGameTag(GameTag.soldier))
        {
            col = collider2D;
            Speed = 1;
            checksoldier = false;
        }

    }
    // Start is called before the first frame update
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
        transform.position += -transform.right * Time.deltaTime * Speed;
        anim.SetBool("run", Speed == 1);
    }
    private void offense()
    {
        anim.SetBool("contect", Speed == 0);
    }
    public void TakeDamage(float damage)
    {
        Hp = Hp - damage;

        if (Hp <= 0)
        {
            Hp = 0;
            destroyFunctiom();
        }

    }

    public void soldierattack()
    {

    }

    public void Monsterattacktime()
    {
        timer += Time.deltaTime;
        if (checksoldier == true)
        {
           
            timer = 0.0f;
        }
        offense();

    }
    public void Soldierattack()
    {
        if (checksoldier == true)

        {
            army armySc = col.GetComponent<army>();
            armySc.Takedamage(damage);
        }
    }


    private void destroyFunctiom()
    {
        Destroy(gameObject);
    }
}
