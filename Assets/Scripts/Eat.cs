using UnityEngine;

public class Slime : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 슬라임이 사라지게 하기
            Destroy(gameObject); // 슬라임 오브젝트 파괴
        
        }
    }
}

