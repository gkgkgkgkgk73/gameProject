using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosGenerate : MonoBehaviour
{

    public GameObject Pos;
    GameObject prePos;
    public float maxLevel = 7f;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    { 
        prePos = Instantiate(Pos);
        prePos.transform.position = new Vector3(-5,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //다시 정리해보자.. 카메라, 사람이 돌아가는걸로 (?) --> 사람 기준으로 카메라 놓기, 사람 회전이동, 사람 속도, 점은 걍 90도 방향으로 찍기만 하면 됨
        //-> 그럼 line 렌더러에 함수로 걍 p1,p2, p3 점 위치만 바꾸면 됨.

        //아니면 점 세 개를 사람 기준으로 회전?
        //->이것도 라인렌더러에 함수로 p1,p2,p3위치랑 속도랑 회전값만 주면 됨.
        //게다가 사람 고정..
        //사람 달리는 모션, 사람(대신 중력 적용, z축 고정, 라인렌더러에 콜라이더 적용) 카메라 고정
        //라인렌더러 함수에 점 위치 속도 회전값 바꾸는 함수
        //제너레이터 없애도 됨.


        //DrawLine의 이동속도, 회전값(왼쪽 오른쪽 키보드 입력으로 받으면 될 듯) prePos에 대입?해서 구현
        

        //화살표 키보드 눌렸을때 pos 생성
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            //prePos연산중

            GameObject newPos = Instantiate(Pos);
            float y = Random.Range(-maxLevel,maxLevel);
            if (y == 0) { y = 3; }
            newPos.transform.position = new Vector3(prePos.transform.position.x, prePos.transform.position.y+y,0);
            prePos = newPos;
            Destroy(newPos,15);
        }

        if (maxLevel > 5)
        {
            if (timer > 2)
            {
                timer = 0;
                maxLevel -= 0.1f;
            }
            else
            {
                timer += Time.deltaTime;

            }
        }

     
    }
}
