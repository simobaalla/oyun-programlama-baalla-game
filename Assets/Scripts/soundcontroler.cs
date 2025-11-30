using UnityEngine;

public class soundcontroler : MonoBehaviour
{
    public void TurnSoundOff()
    {
        AudioListener.pause = true;
    }

    public void TurnSoundOn()
    {
        AudioListener.pause = false;
    }
}
