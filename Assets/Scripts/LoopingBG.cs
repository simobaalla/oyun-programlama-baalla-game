using UnityEngine;
using UnityEngine.Rendering;

public class LoopingBG : MonoBehaviour
{
    public float backgroundSp;
    public Renderer backgroundRenderer;
   
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSp * Time.deltaTime, 0f);
    }
}
