using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    [Tooltip("Velocidad de giro en grados por segundo.")]
    public float rotationSpeed = 180f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
