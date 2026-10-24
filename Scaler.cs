using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 0.5f;

    private void Update()
    {
        transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
    }
}
