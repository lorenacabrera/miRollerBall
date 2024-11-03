using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int totalPickups;      
    private int pickupsCollected = 0; 

    void Start()
    {
        // Contamos todos los objetos con la etiqueta "Pickup" en la escena al inicio
        totalPickups = GameObject.FindGameObjectsWithTag("Pickup").Length;
    }
    public void PickupCollected()
    {
        pickupsCollected++;
        Debug.Log("Pickup recogido: " + pickupsCollected + " de " + totalPickups);

        
        // Si el jugador ha recogido todos los pickups, cargamos el siguiente nivel
        if (pickupsCollected >= 4)
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {

        Debug.Log("cambiando a la siguiente escena");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}