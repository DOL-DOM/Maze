using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameManagerLogic manager;
    private float h = 0.0f;
    private float v = 0.0f;
    private float r = 0.0f;
    private float moveSpeed = 10.0f;
    private float rotationSpeed = 100.0f;
    private Transform playerTr;
    public int itemCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerTr = GetComponent<Transform>();
    }

    // Update is called once per frame, 이동 및 회전
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");
        Debug.Log("H:" + h.ToString() + "V:" + v.ToString());
        playerTr.Translate(new Vector3(h, 0, v) * moveSpeed * Time.deltaTime);
        playerTr.Rotate(new Vector3(0, r, 0) * rotationSpeed * Time.deltaTime);
    }
    // 충돌 관리
    void OnTriggerEnter(Collider other){
        

        if (other.tag == "Item"){ //충돌 오브젝트가 아이템일때
            
            itemCount++; // 점수 올리기 
            Debug.Log("아이템 개수: " + itemCount);

        }
    
    }
}