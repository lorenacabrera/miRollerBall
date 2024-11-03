using UnityEngine;

public class GoalTrigger : MonoBehaviour

{
    public LevelManager levelManager; // Referencia al LevelManager

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            // Llama al método LoadNextLevel cuando el jugador colisiona con la meta
            levelManager.LoadNextLevel();
        }
    }
}    


    

