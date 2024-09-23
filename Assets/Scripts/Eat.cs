using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
     public Control playerControl; // Control 인스턴스를 참조하는 변수

   // 초콜릿 획득 시, 효과를 처리하는 함수
    void OnTriggerEnter(Collider other)
    {
        // 만약 플레이어와 초콜릿 충돌했다면
        if (other.CompareTag("Player"))
        {
            //획득 로직 
            playerControl.itemCount++;
            Debug.Log("초콜릿을 획득했습니다!현재 아이템 개수: " + playerControl.itemCount);

            // 삭제
            Destroy(gameObject);
        }
    }

    
}
