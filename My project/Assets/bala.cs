using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bala : MonoBehaviour
{
    
    public GameObject efectoImpacto; // Efecto de impacto de la bala

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verificar si la bala chocó con una pared
        if (collision.gameObject.CompareTag("Ladrillo"))
        {
            // Instanciar efecto de impacto
            Instantiate(efectoImpacto, transform.position, Quaternion.identity);

            // Destruir la bala
            Destroy(gameObject);
        }
    }
}
