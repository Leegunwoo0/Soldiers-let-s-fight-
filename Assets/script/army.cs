using UnityEngine;

public class army : MonoBehaviour
{
    [Header("army¡§∫∏")]
    [SerializeField] float Speed = 1f;
    [SerializeField] float Hp = 10f;
    [SerializeField] float damage = 3f;

    [SerializeField] float damagetime = 0.5f;
    float timer;
    Collider2D col;
    bool checkEnemytower = false;
    Animator anim;
    private void Awake()
    {

        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collider2D)
    {

        if (collider2D.tag == Tool.GetGameTag(GameTag.EnemyTower))
        {
            col = collider2D;
            Speed = 0;
            checkEnemytower = true;
        }

   
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (checkEnemytower == true)
        {
            Enemytowerattacktime();
        }

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


    public void EnemyTowerattack()
    {

        if (checkEnemytower == true)
        {
            enemytower enemytowerSc = col.GetComponent<enemytower>();
            enemytowerSc.TakeDamage(damage);
         
        }

    }


    public void Enemytowerattacktime()
    {
        timer += Time.deltaTime;
        if (timer >= damagetime)
        {

            if (checkEnemytower == true)
            {
                EnemyTowerattack();
                timer = 0.0f;
            }



        }
        offense();


    }
    
  public void Collapse(float EtowerHp)
    {
        if (EtowerHp < 0)
        {
            checkEnemytower = false;
        }
    }

}
