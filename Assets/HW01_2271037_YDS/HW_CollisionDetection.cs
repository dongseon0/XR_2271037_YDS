using UnityEngine;

public class HW_CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision detected with: {collision.gameObject.name}");

        // Sphere와 충돌했을 때
        if (collision.gameObject.CompareTag("Sphere"))
        {
            Debug.Log("Destroying Sphere");
            Destroy(collision.gameObject);  // Sphere 오브젝트 삭제
        }
    }
}
