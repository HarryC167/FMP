using UnityEngine;

public class Next : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManagment.instance.NextLevel1();
        }
    }
}
