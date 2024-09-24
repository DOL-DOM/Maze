using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshPro 사용 시 필요

public class GameManagerLogic : MonoBehaviour
{
    public TextMeshProUGUI successMessage; // UI 텍스트를 참조하는 변수
    private bool gameEnded = false; // 게임 종료 여부 확인
    public Control playerControl; // Control 인스턴스를 참조하는 변수
       public GameObject finishPanel; // Finish 패널을 참조하는 변수

    // Start is called before the first frame update
    void Start()
    {
        if (playerControl == null)
        {
            Debug.LogError("playerControl이 할당되지 않았습니다. Inspector에서 할당해주세요.");
            return; // null인 경우 더 이상 진행하지 않음
        }
        successMessage.gameObject.SetActive(false); // 게임 시작 시 성공 메시지를 비활성화
        finishPanel.SetActive(false); // 패널 비활성화
    }
  // 게임 성공을 처리하는 함수
    public void GameSuccess()
    {
        if (!gameEnded)
        {
            // 성공 메시지 활성화
            successMessage.gameObject.SetActive(true);
            gameEnded = true;
            Debug.Log("게임 성공!");
        }
    }
    // Update is called once per frame
    void Update()
    {
         // 슬라임 3개를 만났는지 체크
        if (playerControl.itemCount >= 3 && !gameEnded)
        {
            // 결승점에 도달했는지 체크
            if (playerControl.itemCount >= 3 && playerControl.hasReachedFinish && !gameEnded)
        {
            finishPanel.SetActive(true); // Finish 패널 활성화
            GameSuccess();
        }
        }
    }
}
