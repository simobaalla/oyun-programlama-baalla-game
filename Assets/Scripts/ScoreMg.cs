using UnityEngine;
using TMPro;   

public class ScoreMg : MonoBehaviour
{
    public TextMeshProUGUI scoretxt;
    private float score;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoretxt.text = ((int)score).ToString();
        }
    }
}
