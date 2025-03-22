using UnityEngine;

public class HW_CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision detected with: {collision.gameObject.name}");

        if (collision.gameObject.CompareTag("Sphere"))
        {
            Debug.Log("Destroying Sphere now...");
            // 잠시 대기 후 Destroy() 호출
            Invoke(nameof(DestroySphere), 0.1f);
        }
    }

    void DestroySphere()
    {
        Destroy(gameObject);  // 실제로 오브젝트 삭제
    }
}
