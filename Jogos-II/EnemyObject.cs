using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//muito interessante isso, ele cria um menu com os atributos abaixo
// e após o Enemy/, ele cria um sub-Menu.
// no Unity, botao direito -> Create -> Enemy -> New Enemy.

[CreateAssetMenu(fileName = "enemyAttributes", menuName = "Enemy/New Enemy")]
public class EnemyObject : ScriptableObject
{
	public string name;
	public float health;
	public float speed;
	public float attack;

}