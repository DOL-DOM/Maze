using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public Transform respawnPoint; // 리스폰 위치를 참조하는 변수
    public GameObject player; // 플레이어 오브젝트 참조

    // 트리거 충돌 감지 메서드
    void OnTriggerEnter(Collider other)
    {
        // 만약 충돌한 오브젝트가 플레이어일 경우
        if (other.CompareTag("Player"))
        {
            // 플레이어를 리스폰 지점으로 이동
            player.transform.position = respawnPoint.position;
            player.transform.rotation = respawnPoint.rotation; // 필요하면 회전도 초기화
            Debug.Log("플레이어가 리스폰 지점으로 이동했습니다.");
        }
    }
}
