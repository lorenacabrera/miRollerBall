using UnityEngine;

public class Pickup : MonoBehaviour 
{
    
public LevelManager levelManager;

    void Start()
    {
        // Encontramos el LevelManager en la escena
       levelManager = Object.FindFirstObjectByType<LevelManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Notificamos al LevelManager de que este Pickup ha sido recogido
            levelManager.PickupCollected();

            // Destruimos o desactivamos el pickup tras recogerlo
            Destroy(gameObject);
        }
    }
}
