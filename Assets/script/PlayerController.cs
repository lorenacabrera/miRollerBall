using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb; 
    private int count;
    private float movementX;
    private float movementY;
    private bool isGrounded = true;
    private bool isGameOver = false;

    public float speed = 10f; 
    public float jumpForce = 10f;
    public float fallLimit = -10f;

    public TextMeshProUGUI countText;
    public TextMeshProUGUI gameOverText;
    public GameObject nextTextObject;

    // Start
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        count = 0;
        SetCountText();

        nextTextObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
    }

    // Movimiento: nuevo Input System
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    // Actualizar contador de recolectables
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 4)  
        {
            nextTextObject.SetActive(true);
        }
    }

    // Físicas del jugador
    private void FixedUpdate();
   private void FixedUpdate()
{
    if (isGameOver) return;  // Bloquear controles si hay Game Over

    // Movimiento
    Vector3 movement = new Vector3(movementX, 0.0f, movementY);
    rb.AddForce(movement * speed);

    // Salto
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }

    // Detectar caída
    if (transform.position.y < fallLimit)
    {
        GameOver();
    }
}


    // Recolección de objetos
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;

            SetCountText();
        }
    }

    // Detectar si toca el suelo para saltar
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Game Over
    private void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        // Detener movimiento del jugador
        rb.linearVelocity = Vector3.zero;
        rb.isKinematic = true;

        // Mostrar mensaje
        gameOverText.gameObject.SetActive(true);

        // Reiniciar la escena después de 3 segundos
        Invoke("RestartLevel", 3f);
    }

    // Reiniciar nivel
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
