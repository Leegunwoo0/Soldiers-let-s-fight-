using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Unity.VisualScripting;
using static enemytower;

public class enemytower : MonoBehaviour
{
    public enum enemyTower
    {
        SmailEnemyTowerA,
        BigEnemyTower,
        SmailEnemyTowerB
    }

    [Header("enemytower 정보")]
    [SerializeField] float enemytowerhp = 30f;// 타워hp
    Collider2D col;



    // Start is called before the first frame update

    private void Awake()
    {
        col = GetComponent<Collider2D>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       




    }
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {
        enemytowerhp = enemytowerhp - damage;

        if (enemytowerhp <= 0)
        {
            enemytowerhp = 0;
            destroyFunctiom();
        }

    }

    public void Collapse()
    {
        
    }

    public void DestroyOnBodySlam()
    {
        destroyFunctiom();
    }

    private void destroyFunctiom()
    {
        Destroy(gameObject);
    }

}
