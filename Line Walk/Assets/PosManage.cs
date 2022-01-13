using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosManage : MonoBehaviour
{

    public GameObject P0;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
   
    float maxLevel = 4f;
    float timer = 0;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        P0.transform.position = new Vector3(15,0,0);
        P1.transform.position = new Vector3(0,0,0);
        P2.transform.position = new Vector3(-5,0,0);
        P3.transform.position = new Vector3(-5,-3,0);
        P4.transform.position = new Vector3(-10,-3,0);
        P5.transform.position = new Vector3(-10,-4,0);
    }

    // Update is called once per frame
    void Update()
    {
        //왼쪽 회전 y축 중심으로 회전변환
        if (Input.GetKeyDown(KeyCode.LeftArrow))


        {
            float a = P2.transform.position.x;
            float b = P2.transform.position.y;
            P0.transform.position = new Vector3(P0.transform.position.y*-1+a+b,P0.transform.position.x-a+b,0);
            P1.transform.position = new Vector3(P1.transform.position.y * -1 + a + b, P1.transform.position.x - a + b, 0);

            P3.transform.position = new Vector3(P3.transform.position.y * -1 + a + b, P3.transform.position.x - a + b, 0);

            P4.transform.position = new Vector3(P4.transform.position.y * -1 + a + b, P4.transform.position.x - a + b, 0);
            P5.transform.position = new Vector3(P5.transform.position.y * -1 + a + b, P5.transform.position.x - a + b, 0);
            //변화 후 플레이어만큼 앞으로 더 가기
            P0.transform.position += Vector3.right * speed;
            P1.transform.position += Vector3.right * speed;
            P2.transform.position += Vector3.right * speed;
            P3.transform.position += Vector3.right * speed;
            P4.transform.position += Vector3.right * speed;
            P5.transform.position += Vector3.right * speed;
        }
        //오른쪽 회전
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            float a = P2.transform.position.x;
            float b = P2.transform.position.y;
            P0.transform.position = new Vector3(P0.transform.position.y + a - b, P0.transform.position.x * -1 + a + b, 0);
            P1.transform.position = new Vector3(P1.transform.position.y + a - b, P1.transform.position.x * -1 + a + b, 0);
            P3.transform.position = new Vector3(P3.transform.position.y + a - b, P3.transform.position.x * -1 + a + b, 0);
            P4.transform.position = new Vector3(P4.transform.position.y + a - b, P4.transform.position.x * -1 + a + b, 0);
            P5.transform.position = new Vector3(P5.transform.position.y + a - b, P5.transform.position.x * -1 + a + b, 0);
            //변화 후 플레이어만큼 앞으로 더 가기
            P0.transform.position += Vector3.right * speed * 0.5f;
            P1.transform.position += Vector3.right * speed * 0.5f;
            P2.transform.position += Vector3.right * speed * 0.5f;
            P3.transform.position += Vector3.right * speed * 0.5f;
            P4.transform.position += Vector3.right * speed * 0.5f;
            P5.transform.position += Vector3.right * speed * 0.5f;
        }

        //만약 회전되었다면 왼쪽이면 지금 ㅇㅇ 오른족이면 

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            float tpx;
            float tpy;
            //pos 다시 조정

            tpx = P1.transform.position.x;
            tpy = P1.transform.position.y;
            P0.transform.position = new Vector3(tpx,tpy);

            tpx = P2.transform.position.x;
            tpy = P2.transform.position.y;

            P1.transform.position = new Vector3(tpx,tpy);
            tpx = P3.transform.position.x;
            tpy = P3.transform.position.y;
            P2.transform.position = new Vector3(tpx,tpy);
            tpx = P4.transform.position.x;
            tpy = P4.transform.position.y;
            P3.transform.position = new Vector3(tpx, tpy);
            tpx = P5.transform.position.x;
            tpy = P5.transform.position.y;
            P4.transform.position = new Vector3(tpx, tpy);
            //P5 랜덤 지정
            //p3,p4의 x값이 같으면 x값 랜덤 지정
            if (P3.transform.position.x == P4.transform.position.x)
            {
                float dx = Random.Range(3,8);
                float seed = Random.Range(0,1);
                if (seed >= 0.5f)
                {
                    seed = 1;
                }
                else
                {
                    seed = -1;
                }
                tpx += dx * seed;
            }
            //아니면 y값 랜덤 지정
            else 
            {
                float dy = Random.Range(3, 5);
                float seed = Random.Range(0, 1);
                if (seed >= 0.5f)
                {
                    seed = 1;
                }
                else
                {
                    seed = -1;
                }
                tpy += dy * seed;
            }
            
            P5.transform.position = new Vector3(tpx, tpy, 0);
        }


        //기본 점 속도
            P0.transform.position += Vector3.right * speed * Time.deltaTime;
            P1.transform.position += Vector3.right * speed * Time.deltaTime;
            P2.transform.position += Vector3.right * speed * Time.deltaTime;
            P3.transform.position += Vector3.right * speed * Time.deltaTime;
            P4.transform.position += Vector3.right * speed * Time.deltaTime;
            P5.transform.position += Vector3.right * speed * Time.deltaTime;
       
        
        
        //난이도에 따라 선 길이 폭 감소
        if (maxLevel > 3)
        {
            if (timer > 2)
            {
                timer = 0;
                maxLevel -= 0.01f;
            }
            else
            {
                timer += Time.deltaTime;

            }
        }
        
        //난이도 증가에 따라 선 지나가는 속도 증가
        if (speed<=4)
        {
            speed += 0.05f*Time.deltaTime;
        }
    }
}
