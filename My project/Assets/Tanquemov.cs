using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanquemov : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
 
    private Rigidbody rb;
    public GameObject winTextObject; // Referencia al objeto de texto "¡Has ganado!"
    
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtener el componente Rigidbody
        // Desactivar el texto al inicio
        winTextObject.SetActive(false);
    }
 
    void FixedUpdate()
    {
        // Verificar si alguna tecla de movimiento está presionada
        bool isMoving = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) ||
                        Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) ||
                        Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ||
                        Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
 
        // Si alguna tecla de movimiento está presionada, aplicar movimiento hacia adelante
        if (isMoving)
        {
            // Obtener la dirección hacia adelante del tanque (basada en su rotación actual)
            Vector3 moveDirection = transform.forward;
 
            // Aplicar movimiento hacia adelante en la dirección actual del tanque
            rb.velocity = moveDirection * moveSpeed;
        }
        else
        {
            // Si no se presiona ninguna tecla de movimiento, detener el movimiento
            rb.velocity = Vector3.zero;
        }
    }
 
    void Update()
    {
        
        // Rotar el tanque según la tecla presionada
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            // Rotar hacia arriba (0 grados)
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            // Rotar hacia la derecha (90 grados)
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            // Rotar hacia la izquierda (-90 grados)
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            // Rotar hacia abajo (180 grados)
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        
    }

        void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que colisionó es un "Pig"
        if (collision.gameObject.CompareTag("Pig"))
        {
            // Activar el texto "¡Has ganado!"
            winTextObject.SetActive(true);
        }
    }
}
