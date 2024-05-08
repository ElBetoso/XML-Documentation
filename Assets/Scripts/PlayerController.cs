using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controlador del jugador para un cubo en Unity.
/// Permite al jugador mover el cubo hacia adelante, atrás, izquierda y derecha.
/// </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// Velocidad de movimiento del jugador.
    /// </summary>
    public float speed = 5f;

    // Update se llama una vez por frame
    void Update()
    {
        // Obtener las entradas de teclado para el movimiento
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcular la dirección del movimiento
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Mover el jugador en la dirección calculada
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
