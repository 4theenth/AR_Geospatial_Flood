using UnityEngine;

public class NearestShelterTracker : MonoBehaviour
{
    [Header("References")]
    public Transform player;
    public Transform[] shelters;
    public ShelterInfoManager shelterInfoManager;
    public UIManager uiManager;

    [Header("Settings")]
    public float shelterRadius = 20f;

    private Transform nearestShelter;
    private bool isInsideShelter = false;

    void Start()
    {
        if (uiManager != null)
            uiManager.ShowShelterInfoPanel();

        if (shelterInfoManager != null && player != null)
            shelterInfoManager.SetReferences(player); // 🔥 WAJIB
    }

    void Update()
    {
        if (player == null || shelters.Length == 0 || shelterInfoManager == null)
            return;

        float minDist = Mathf.Infinity;
        Transform closest = null;

        // 🔍 Cari shelter terdekat
        foreach (var s in shelters)
        {
            float dist = Vector3.Distance(player.position, s.position);
            if (dist < minDist)
            {
                minDist = dist;
                closest = s;
            }
        }

        nearestShelter = closest;

        // 🎯 Cek apakah user masuk radius shelter
        isInsideShelter = minDist <= shelterRadius;

        // 🔄 Update UI (HYBRID MODE)
        if (isInsideShelter)
        {
            shelterInfoManager.UpdateShelterInfo(
                nearestShelter,
                nearestShelter.name,
                minDist,
                "You are in shelter area",
                false // mode proximity
            );
        }
        else
        {
            shelterInfoManager.UpdateShelterInfo(
                nearestShelter,
                nearestShelter.name,
                minDist,
                "Available",
                true // mode nearest
            );
        }
    }
}