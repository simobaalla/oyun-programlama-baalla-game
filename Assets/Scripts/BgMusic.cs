using UnityEngine;

public class BgMusic : MonoBehaviour
{
    private static BgMusic backgroundmusic;
    private void Awake()
    {
        if (backgroundmusic == null)
        {
            backgroundmusic = this;
            DontDestroyOnLoad(backgroundmusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
