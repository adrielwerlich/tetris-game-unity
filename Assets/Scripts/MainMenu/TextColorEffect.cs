using UnityEngine;
using TMPro;

public class TextColorEffect : MonoBehaviour
{
    private TMP_Text textMeshPro;
    private float colorChangeSpeed = 2f; // Speed of the color change

    void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
    }

    void Update()
    {
        // Create a glittering effect by cycling through colors
        float r = Mathf.Sin(Time.time * colorChangeSpeed) * 0.5f + 0.5f;
        float g = Mathf.Sin(Time.time * colorChangeSpeed + 2f) * 0.5f + 0.5f;
        float b = Mathf.Sin(Time.time * colorChangeSpeed + 4f) * 0.5f + 0.5f;

        textMeshPro.color = new Color(r, g, b);
    }
}