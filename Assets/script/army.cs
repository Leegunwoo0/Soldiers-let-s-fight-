using UnityEngine;

public class army : MonoBehaviour
{
    [Header("army¡§∫∏")]
    [SerializeField] float Speed = 1f;
    [SerializeField] float Hp = 10f;
    [SerializeField] float damage = 3f;
    float timer;
    int toweDamage;
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
        if(collision.tag == Tool.GetGameTag(GameTag.EnemyTower ))
        {
            collision.GetComponent<enemytower>().TakeDamage(damage);
            offense();
        }
      
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

    public void Hit()
    {
        Hp--;
            if( Hp < 0 )
        {
            Hp = 0;
        }
    }


}
