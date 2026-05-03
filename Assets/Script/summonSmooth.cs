using UnityEngine;
using System;

public class summonSmooth : MonoBehaviour
{
    public event Action OnFloodAnimationFinished;

    [Header("Durasi Animasi Naik (detik)")]
    public float riseDuration = 3f;

    [Header("ROOT Objek Flood (Plane + efek air)")]
    [Tooltip("Isi dengan parent yang berisi Plane visual air")]
    public GameObject floodObject;

    [Header("Ketinggian Air per Intensitas (cm)")]
    public float lowHeightCm = 0f;
    public float mediumHeightCm = 40f;
    public float highHeightCm = 80f;
    public float veryHeavyHeightCm = 80f;

    [Header("Efek Halus")]
    [Range(0f, 1f)] public float smoothness = 0.15f;

    [Header("Offset Manual (meter)")]
    public float heightOffset = 0f;

    [SerializeField] private gelombang waveController;

    private Vector3 initialLocalPosition;
    private float currentY;
    private float targetY;
    private bool rising = false;
    private bool initialized = false;

    void Start()
    {
        // ❌ Tidak disarankan untuk AR Geospatial
        // SetToGround();

        initialLocalPosition = transform.localPosition + Vector3.up * heightOffset;
        currentY = initialLocalPosition.y;
        targetY = initialLocalPosition.y + (lowHeightCm / 100f);

        // Flood mulai dalam keadaan mati
        if (floodObject != null)
            floodObject.SetActive(false);

        initialized = true;
    }

    void Update()
    {
        if (!initialized || !rising) return;

        currentY = Mathf.Lerp(currentY, targetY, Time.deltaTime / smoothness);

        transform.localPosition = new Vector3(
            initialLocalPosition.x,
            currentY,
            initialLocalPosition.z
        );

        if (Mathf.Abs(currentY - targetY) < 0.001f)
        {
            transform.localPosition = new Vector3(
                initialLocalPosition.x,
                targetY,
                initialLocalPosition.z
            );

            rising = false;
            OnFloodAnimationFinished?.Invoke();
        }
    }

    // =============================
    // UBAH KETINGGIAN AIR
    // =============================
    public void UpdateFloodHeight(float heightMeters)
    {
        transform.localPosition = initialLocalPosition;
        currentY = initialLocalPosition.y;
        targetY = initialLocalPosition.y + heightMeters;

        rising = true;
    }

    // =============================
    // SET INTENSITAS HUJAN
    // =============================
    public void SetFloodIntensity(string intensity)
    {
        float riseHeight = 0f;

        string key = intensity.ToLower().Replace(" ", "").Replace("-", "");

        switch (key)
        {
            case "low":
                riseHeight = lowHeightCm / 100f;
                break;

            case "medium":
                riseHeight = mediumHeightCm / 100f;
                break;

            case "high":
                riseHeight = highHeightCm / 100f;
                break;

            default:
                riseHeight = lowHeightCm / 100f;
                break;
        }

        UpdateFloodHeight(riseHeight);

        if (waveController != null)
            waveController.SetWaveIntensity(key);
    }

    // =============================
    // AKTIFKAN BANJIR
    // =============================
    public void StartSummon()
    {
        if (floodObject != null)
            floodObject.SetActive(true);

        rising = true;
    }

    // =============================
    // MATIKAN BANJIR
    // =============================
    public void StopSummon()
    {
        rising = false;

        if (floodObject != null)
            floodObject.SetActive(false);
    }
}
