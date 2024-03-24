using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public GameObject enemyBullet;
    public float enemySpeed;
    [SerializeField] private float Timer = 5;
    public float rangeToShoot;
    public Transform spawnPoint;
    bool isShooting;

    public void Update()
    {
        enemy.SetDestination(Player.position);

        float distance = Vector3.Distance(transform.position, Player.position);

        if (distance <= rangeToShoot)
        {
            if (!isShooting)
            {
                InvokeRepeating("ShootAtPlayer", 0f, 0.5f);
                isShooting = true;
            }
        }
        else
        {
            CancelInvoke("ShootAtPlayer");
        }
    }

    void ShootAtPlayer()
    {
        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.position, Quaternion.identity);
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce((Player.position - spawnPoint.position).normalized * enemySpeed, ForceMode.Impulse);
        Destroy(bulletObj, 5f);
    }
}
