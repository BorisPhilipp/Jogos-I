using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//tava com erro de digita��o em: Ontriggerenter e GameObject

public class BulletScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}