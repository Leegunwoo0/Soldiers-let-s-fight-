using UnityEditor.AssetImporters;
using UnityEngine;

public class army : MonoBehaviour
{
    [Header("army¡§∫∏")]
    [SerializeField] float Speed = 1f;
    [SerializeField] float Hp = 40f;
    [SerializeField] float damage = 3f;

    [SerializeField] float damagetime = 0.5f;
    float timer;
    Collider2D col;
    bool checkEnemytower = false;
    bool checkMonster = false;
    Animator anim;
    private void Awake()
    {

        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == Tool.GetGameTag(GameTag.monster) || collider2D.tag == Tool.GetGameTag(GameTag.EnemyTower))
        {
            col = collider2D;
            Speed = 0;
            checkMonster = true;
        }


    }
    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.tag == Tool.GetGameTag(GameTag.EnemyTower)|| (collider2D.tag == Tool.GetGameTag(GameTag.monster)))
        {
            col = collider2D;
            Speed = 1;
            checkEnemytower = false;
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
        else if (checkMonster == true)
        {
            Monsterattacktime();
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

    public void Takedamage(float _damage)
    {
        Hp = Hp - _damage;
        if (Hp < 0)
        {
            Hp = 0;
            anim.SetBool("death", Hp == 0);
            destroyFunctiom();
        }
    }
    private void destroyFunctiom()
    {
        Destroy(gameObject);
    }

    public void EnemyTowerattack()
    {

        if (checkEnemytower == true)
        {
            enemytower enemytowerSc = col.GetComponent<enemytower>();
            enemytowerSc.TakeDamage(damage);

        }

    }
    public void Monsterattack()
    {
        if (checkMonster == true)
        {
            MushroomMonster mushroomMonster = col.GetComponent<MushroomMonster>();
            mushroomMonster.TakeDamage(damage);
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
    public void Monsterattacktime()

    {
        timer += Time.deltaTime;
        if (checkMonster == true)
        {
            Monsterattack();
            timer = 0.0f;
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

    public void Kill(float Monsterhp)
    {
        if (Monsterhp < 0)
        {
            checkMonster = false;
        }
    }

}
