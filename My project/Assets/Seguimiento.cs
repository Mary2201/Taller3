using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public Transform Tanquecito; // Referencia al transform del jugador (tanque)
    public float suavizado = 5f; // Factor de suavizado del movimiento de la cámara

    private Vector3 offset; // Distancia entre la cámara y el jugador al inicio

    void Start()
    {
        // Calcula el offset inicial entre la cámara y el jugador
        offset = transform.position - Tanquecito.position;
    }

    void Update()
    {
        // Calcula la posición objetivo de la cámara
        Vector3 posicionObjetivo = Tanquecito.position + offset;

        // Interpolación suave hacia la posición objetivo
        transform.position = Vector3.Lerp(transform.position, posicionObjetivo, suavizado * Time.deltaTime);
    }

}
