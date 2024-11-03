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

 public float speed = 10f; 
 public float jumpForce = 10f;
 public float fallLimit = -10f;
 public TextMeshProUGUI countText;
 public TextMeshProUGUI gameOverText;
 public GameObject nextTextObject;

 // Start is called before the first frame update.
 void Start()
    {
 
        rb = GetComponent<Rigidbody>();
        
        count = 0;

        SetCountText();
        nextTextObject.SetActive(false);

      gameOverText.gameObject.SetActive(false);
      

    }
 
 // This function is called when a move input is detected.
 void OnMove(InputValue movementValue)
    {
 // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

 // Store the X and Y components of the movement.
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    void SetCountText()
    {
       countText.text = "Count: " + count.ToString();
       if(count >= 4)
       {
              nextTextObject.SetActive(true);
       }
    }
 private void FixedUpdate() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
 // Create a 3D movement vector using the X and Y inputs.
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

 // movimiento
        rb.AddForce(movement * speed); 

 //salto       
         if (Input.GetKeyDown (KeyCode.Space) && isGrounded)
         {
         rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
         isGrounded = false;
         }  
    
 //  verificar si ha caido 

         if (transform.position.y < fallLimit)
         {
            GameOver();
         }
    }

 private void OnTriggerEnter(Collider other) 
   {
       if (other.gameObject.CompareTag("Pickup")) 
       {
           other.gameObject.SetActive(false);
           count = count + 1;

           SetCountText();
       }
   }  

 private void OnCollisionEnter(Collision collision)
   {
      if(collision.gameObject.CompareTag("Ground"))
      {
         isGrounded = true;
         
      }    
    }

 private void GameOver()
{
   gameOverText.gameObject.SetActive(true);

   Invoke("RestartLevel", 3f);
}

 private void RestartLevel()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}