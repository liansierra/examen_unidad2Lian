using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pico"))
        {
            Debug.Log(transform.parent.name + " murio");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
