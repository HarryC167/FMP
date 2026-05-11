using UnityEngine;

public class Next : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (goNextLevel)
            {
                SceneManagment.instance.NextLevel1();
            }
            else
            {
                SceneManagment.instance.LoadScene(levelName);
            }
        }
    }
}
