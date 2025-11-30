using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPn;
    void Start()
    {
        
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            GameOverPn.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
