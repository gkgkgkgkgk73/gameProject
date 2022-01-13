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
        //�ٽ� �����غ���.. ī�޶�, ����� ���ư��°ɷ� (?) --> ��� �������� ī�޶� ����, ��� ȸ���̵�, ��� �ӵ�, ���� �� 90�� �������� ��⸸ �ϸ� ��
        //-> �׷� line �������� �Լ��� �� p1,p2, p3 �� ��ġ�� �ٲٸ� ��.

        //�ƴϸ� �� �� ���� ��� �������� ȸ��?
        //->�̰͵� ���η������� �Լ��� p1,p2,p3��ġ�� �ӵ��� ȸ������ �ָ� ��.
        //�Դٰ� ��� ����..
        //��� �޸��� ���, ���(��� �߷� ����, z�� ����, ���η������� �ݶ��̴� ����) ī�޶� ����
        //���η����� �Լ��� �� ��ġ �ӵ� ȸ���� �ٲٴ� �Լ�
        //���ʷ����� ���ֵ� ��.


        //DrawLine�� �̵��ӵ�, ȸ����(���� ������ Ű���� �Է����� ������ �� ��) prePos�� ����?�ؼ� ����
        

        //ȭ��ǥ Ű���� �������� pos ����
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            //prePos������

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
