using UnityEngine;

public class MirrorCamera : MonoBehaviour
{
    public Transform mainCamera;
    public Transform waterPlane;

    void LateUpdate()
    {
        if (mainCamera == null || waterPlane == null) return;

        // Posisi kamera pantulan (Simetri terhadap permukaan air)
        Vector3 pos = mainCamera.position;
        pos.y = 2 * waterPlane.position.y - mainCamera.position.y;
        transform.position = pos;

        // Rotasi kamera pantulan
        Vector3 rot = mainCamera.eulerAngles;
        transform.eulerAngles = new Vector3(-rot.x, rot.y, rot.z);
    }
}