using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del jugador

    // Update is called once per frame
    void Update()
    {
        // Obtener el input del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // A/D o flechas izquierda/derecha
        float movimientoVertical = Input.GetAxis("Vertical"); // W/S o flechas arriba/abajo

        // Crear un vector de movimiento basado en el input
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);

        // Mover al jugador
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
    }
}
