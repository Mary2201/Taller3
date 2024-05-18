using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBrick : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que colisionó es una bala
        if (collision.gameObject.CompareTag("Bala"))
        {
            // Destruye el ladrillo
            Destroy(gameObject);

            //destruccion de bala
            Destroy(collision.gameObject);
        }
    }
}