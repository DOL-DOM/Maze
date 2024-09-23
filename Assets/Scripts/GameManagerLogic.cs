using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshPro 사용 시 필요

public class GameManagerLogic : MonoBehaviour
{
    public TextMeshProUGUI successMessage; // UI 텍스트를 참조하는 변수
    private bool gameEnded = false; // 게임 종료 여부 확인
     public int TotalItemCount;  //슬라임 개수 카운트함
    public Control playerControl; // Control 인스턴스를 참조하는 변수
    
    // Start is called before the first frame update
    void Start()
    {
        successMessage.gameObject.SetActive(false); // 게임 시작 시 성공 메시지를 비활성화
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
          if (playerControl.itemCount>=3)
        {
            GameSuccess();
        }
    }
}
