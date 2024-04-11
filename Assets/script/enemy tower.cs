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
    [SerializeField] float enemytowerHp = 30f;// 타워hp
    float timer;//시간
    float damagetime = 0.1f;



    // Start is called before the first frame update


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


        //enemytowerHp = enemytowerHp - damage;

        //if (enemytowerHp < 0)
        //{
        //    enemytowerHp = 0;
        //}



        timer += Time.deltaTime;
        if (timer > damagetime)
        {
            enemytowerHp = enemytowerHp - damage;

            timer = 0.0f;
        }



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
