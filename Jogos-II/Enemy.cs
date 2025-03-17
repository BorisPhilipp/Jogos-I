using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public EnemyObject enemySettings;

	public string name;
	public float health;
	public float speed;
	public float attack;

	//herdará os atributos acima quando atribuir o EnemyObject criado pelo sub-menu
	//ao Enemy Settings deste Script.
	private void start()
	{
		name = enemySettings.name;
		health = enemySettings.health;
		speed = enemySettings.speed;
		attack = enemySettings.attack;
	}
}