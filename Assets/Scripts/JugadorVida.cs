using UnityEngine;
using UnityEngine.UI;  // Para trabajar con la UI
using UnityEngine.SceneManagement;  // Para manejar escenas

public class JugadorVida : MonoBehaviour
{
    public float vidaMaxima = 100f;  // Vida máxima del jugador
    private float vidaActual;        // Vida actual del jugador
    public Slider barraDeVida;       // Referencia a la barra de vida en la UI

    void Start()
    {
        // Inicializamos la vida actual con la vida máxima al inicio
        vidaActual = vidaMaxima;

        // Asegúrate de que la barra de vida esté completamente llena al inicio
        barraDeVida.maxValue = vidaMaxima;
        barraDeVida.value = vidaActual;
    }

    // Método para recibir daño
    public void RecibirDanio(float cantidad)
    {
        vidaActual -= cantidad;

        // Asegúrate de que la vida no baje de cero
        vidaActual = Mathf.Max(vidaActual, 0);

        // Actualizar la barra de vida
        barraDeVida.value = vidaActual;

        // Si la vida llega a 0, reiniciamos la escena
        if (vidaActual <= 0)
        {
            Morir();
        }
    }

    // Método para cuando el jugador muere
    void Morir()
    {
        // Aquí puedes agregar la lógica para cuando el jugador muere, como desactivar el personaje, mostrar un mensaje de "Game Over", etc.
        Debug.Log("El jugador ha muerto");

        // Recargar la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
