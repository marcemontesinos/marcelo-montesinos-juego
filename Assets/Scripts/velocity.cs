using UnityEngine;

public class SpeedBoostItem : MonoBehaviour
{
    public float boostAmount = 2f; // Aumento de velocidad
    public float boostDuration = 5f; // Duración del aumento en segundos

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el jugador toca el ítem
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.ApplySpeedBoost(boostAmount, boostDuration); // Aplica el aumento de velocidad
            }

            Destroy(gameObject); // Destruye el ítem después de recogerlo
        }
    }
}