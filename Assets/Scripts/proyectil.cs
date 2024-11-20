using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20f; // Daño del proyectil

    // Este método se llama cuando el proyectil colisiona con algo
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Obtener el script Enemigo para infligirle daño
            Enemigo enemigo = collision.gameObject.GetComponent<Enemigo>();
            if (enemigo != null)
            {
                enemigo.RecibirDanio(damage);  // Infligir daño al enemigo
            }

            // Destruir el proyectil después de la colisión
            Destroy(gameObject);
        }
    }
}