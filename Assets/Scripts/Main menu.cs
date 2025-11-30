using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void playGame(){

        SceneManager.LoadScene(1);

        }
    public void stopGame() {
        Application.Quit();
    }
}
