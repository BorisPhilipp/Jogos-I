using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    public float enemySpeed = 10f;
    public float attackRange = 5f;
    public float attackRate = 1f;
    public GameObject enemyBullet;
    public Transform spawnPoint;

    private float bulletTime;
    private float timer = 5f;
    private ChaseState chaseState;

    void Start()
    {
        chaseState = GetComponent<ChaseState>();
        bulletTime = timer;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (chaseState != null)
        {
            chaseState.isInAttackRange = (distanceToPlayer <= attackRange);
        }

        if (distanceToPlayer > attackRange)
        {
            enemy.SetDestination(player.position);
        }
        else
        {
            enemy.ResetPath();
            ShootAtPlayer();
        }
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;

        if (enemyBullet != null && spawnPoint != null)
        {
            GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.position, spawnPoint.rotation) as GameObject;
            Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
            if (bulletRig != null)
            {
                Vector3 direction = (player.position - spawnPoint.position).normalized;
                bulletRig.AddForce(direction * enemySpeed, ForceMode.Impulse);
            }
            Destroy(bulletObj, 5f);
        }
    }
}