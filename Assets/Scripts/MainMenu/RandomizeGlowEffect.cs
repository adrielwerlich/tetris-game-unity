using System.Collections;
using UnityEngine;
using TMPro;

public class RandomizeGlowEffect : MonoBehaviour
{
    private Material textMaterial;

    // Current and target values
    [SerializeField] private Color currentColor, targetColor;
    private float currentOffset, targetOffset;
    private float currentInner, targetInner;
    private float currentOuter, targetOuter;
    private float currentPower, targetPower;

    [SerializeField] private float transitionSpeed = 1.5f; // Higher = faster transitions
    [SerializeField] private float randomizeInterval = 2f;
    private float timer = 0f;

    void Start()
    {
        TMP_Text textMeshPro = GetComponent<TMP_Text>();
        textMaterial = textMeshPro.fontMaterial;

        // Initialize current and target values
        currentColor = targetColor = textMaterial.GetColor("_GlowColor");
        // currentOffset = targetOffset = textMaterial.GetFloat("_GlowOffset");
        // currentInner = targetInner = textMaterial.GetFloat("_GlowInner");
        // currentOuter = targetOuter = textMaterial.GetFloat("_GlowOuter");
        currentPower = targetPower = textMaterial.GetFloat("_GlowPower");
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= randomizeInterval)
        {
            timer = 0f;
            RandomizeTargets();
        }

        // Smoothly interpolate towards target values
        currentColor = Color.Lerp(currentColor, targetColor, Time.deltaTime * transitionSpeed);
        // currentOffset = Mathf.Lerp(currentOffset, targetOffset, Time.deltaTime * transitionSpeed);
        // currentInner = Mathf.Lerp(currentInner, targetInner, Time.deltaTime * transitionSpeed);
        // currentOuter = Mathf.Lerp(currentOuter, targetOuter, Time.deltaTime * transitionSpeed);
        currentPower = Mathf.Lerp(currentPower, targetPower, Time.deltaTime * transitionSpeed);

        // Apply to material
        if (textMaterial != null)
        {
            textMaterial.SetColor("_GlowColor", currentColor);
            // textMaterial.SetFloat("_GlowOffset", currentOffset);
            // textMaterial.SetFloat("_GlowInner", currentInner);
            // textMaterial.SetFloat("_GlowOuter", currentOuter);
            textMaterial.SetFloat("_GlowPower", currentPower);
        }
    }

    private void RandomizeTargets()
    {
        targetColor = new Color(Random.value, Random.value, Random.value, 1f);
        // targetOffset = Random.Range(-1f, 1f);
        // targetInner = Random.Range(0f, 1f);
        // targetOuter = Random.Range(0f, 1f);
        targetPower = Random.Range(.5f, 1f);
    }
}