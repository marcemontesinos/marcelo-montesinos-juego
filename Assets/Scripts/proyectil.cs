using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20f; // Da�o del proyectil

    // Este m�todo se llama cuando el proyectil colisiona con algo
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Obtener el script Enemigo para infligirle da�o
            Enemigo enemigo = collision.gameObject.GetComponent<Enemigo>();
            if (enemigo != null)
            {
                enemigo.RecibirDanio(damage);  // Infligir da�o al enemigo
            }

            // Destruir el proyectil despu�s de la colisi�n
            Destroy(gameObject);
        }
    }
}