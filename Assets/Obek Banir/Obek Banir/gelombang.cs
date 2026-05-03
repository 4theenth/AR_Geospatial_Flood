using UnityEngine;

public class gelombang : MonoBehaviour
{
    [Header("Wave Speed")]
    public float lowSpeed = 0.03f;
    public float mediumSpeed = 0.15f;   // dipercepat
    public float highSpeed = 0.3f;     // lebih cepat lagi

    [Header("Wave Height / Strength")]
    public float lowStrength = 0.0015f;
    public float mediumStrength = 0.006f;
    public float highStrength = 0.012f;

    private float currentSpeed;
    private float currentStrength;

    private Renderer rend;
    private Vector2 offset;

    void Start()
    {
        rend = GetComponent<Renderer>();

        // Default: kondisi tenang
        currentSpeed = lowSpeed;
        currentStrength = lowStrength;
    }

    void Update()
    {
        if (currentStrength < 0.004f)
        {
            // LOW: hampir statis, hanya shimmer kecil
            rend.material.mainTextureOffset = new Vector2(
                Mathf.Sin(Time.time * 0.2f) * currentStrength,
                Mathf.Cos(Time.time * 0.2f) * currentStrength
            );
            return;
        }

        // MEDIUM & HIGH
        offset.x += currentSpeed * Time.deltaTime;
        offset.y += currentSpeed * 0.5f * Time.deltaTime;

        rend.material.mainTextureOffset = offset * currentStrength;
    }



    // 🔑 Dipanggil dari summonSmooth
    public void SetWaveIntensity(string intensity)
    {
        switch (intensity.ToLower())
        {
            case "low":
                currentSpeed = lowSpeed;
                currentStrength = lowStrength;
                break;

            case "medium":
                currentSpeed = mediumSpeed;
                currentStrength = mediumStrength;
                break;

            case "high":
                currentSpeed = highSpeed;
                currentStrength = highStrength;
                break;

            default:
                currentSpeed = lowSpeed;
                currentStrength = lowStrength;
                break;
        }
    }
}
