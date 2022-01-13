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
        //���� ȸ�� y�� �߽����� ȸ����ȯ
        if (Input.GetKeyDown(KeyCode.LeftArrow))


        {
            float a = P2.transform.position.x;
            float b = P2.transform.position.y;
            P0.transform.position = new Vector3(P0.transform.position.y*-1+a+b,P0.transform.position.x-a+b,0);
            P1.transform.position = new Vector3(P1.transform.position.y * -1 + a + b, P1.transform.position.x - a + b, 0);

            P3.transform.position = new Vector3(P3.transform.position.y * -1 + a + b, P3.transform.position.x - a + b, 0);

            P4.transform.position = new Vector3(P4.transform.position.y * -1 + a + b, P4.transform.position.x - a + b, 0);
            P5.transform.position = new Vector3(P5.transform.position.y * -1 + a + b, P5.transform.position.x - a + b, 0);
            //��ȭ �� �÷��̾ŭ ������ �� ����
            P0.transform.position += Vector3.right * speed;
            P1.transform.position += Vector3.right * speed;
            P2.transform.position += Vector3.right * speed;
            P3.transform.position += Vector3.right * speed;
            P4.transform.position += Vector3.right * speed;
            P5.transform.position += Vector3.right * speed;
        }
        //������ ȸ��
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            float a = P2.transform.position.x;
            float b = P2.transform.position.y;
            P0.transform.position = new Vector3(P0.transform.position.y + a - b, P0.transform.position.x * -1 + a + b, 0);
            P1.transform.position = new Vector3(P1.transform.position.y + a - b, P1.transform.position.x * -1 + a + b, 0);
            P3.transform.position = new Vector3(P3.transform.position.y + a - b, P3.transform.position.x * -1 + a + b, 0);
            P4.transform.position = new Vector3(P4.transform.position.y + a - b, P4.transform.position.x * -1 + a + b, 0);
            P5.transform.position = new Vector3(P5.transform.position.y + a - b, P5.transform.position.x * -1 + a + b, 0);
            //��ȭ �� �÷��̾ŭ ������ �� ����
            P0.transform.position += Vector3.right * speed * 0.5f;
            P1.transform.position += Vector3.right * speed * 0.5f;
            P2.transform.position += Vector3.right * speed * 0.5f;
            P3.transform.position += Vector3.right * speed * 0.5f;
            P4.transform.position += Vector3.right * speed * 0.5f;
            P5.transform.position += Vector3.right * speed * 0.5f;
        }

        //���� ȸ���Ǿ��ٸ� �����̸� ���� ���� �������̸� 

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            float tpx;
            float tpy;
            //pos �ٽ� ����

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
            //P5 ���� ����
            //p3,p4�� x���� ������ x�� ���� ����
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
            //�ƴϸ� y�� ���� ����
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


        //�⺻ �� �ӵ�
            P0.transform.position += Vector3.right * speed * Time.deltaTime;
            P1.transform.position += Vector3.right * speed * Time.deltaTime;
            P2.transform.position += Vector3.right * speed * Time.deltaTime;
            P3.transform.position += Vector3.right * speed * Time.deltaTime;
            P4.transform.position += Vector3.right * speed * Time.deltaTime;
            P5.transform.position += Vector3.right * speed * Time.deltaTime;
       
        
        
        //���̵��� ���� �� ���� �� ����
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
        
        //���̵� ������ ���� �� �������� �ӵ� ����
        if (speed<=4)
        {
            speed += 0.05f*Time.deltaTime;
        }
    }
}
