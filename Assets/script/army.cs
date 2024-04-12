using UnityEngine;

public class army : MonoBehaviour
{
    [Header("army¡§∫∏")]
    [SerializeField] float Speed = 1f;
    [SerializeField] float Hp = 10f;
    [SerializeField] float damage = 3f;

    [SerializeField] float damagetime = 0.5f;
    float timer;
    Rigidbody2D rigid;
    Collider2D col;
    Animator anim;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Speed = 0;
        if (col.tag == Tool.GetGameTag(GameTag.EnemyTower))
        {
            Ermytowercheck(col);
        }
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Enemytowercheckattack();

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

    public void Hit()
    {
        Hp--;
        if (Hp < 0)
        {
            Hp = 0;
        }
    }

    public void Ermytowercheck(Collider2D col)
    {
        if (col.tag == Tool.GetGameTag(GameTag.EnemyTower))
        {
            Enemytowerattack(col);
        }
    }


   private void  Enemytowercheckattack()
    {
        Enemytowerattack(col);
    }
    public void Enemytowerattack(Collider2D col)
    {
        timer += Time.deltaTime;
        if (timer >= damagetime)
        {
            col.GetComponent<enemytower>().TakeDamage(damage);
            timer = 0.0f;


        }
        offense();
    }

}
