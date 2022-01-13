using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    public LineRenderer line;
    EdgeCollider2D edgeCollider;
    public Transform p0;
    public Transform p1;
    public Transform p2;
    public Transform p3;
    public Transform p4;
    public Transform p5;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent < LineRenderer > ();
        line.SetPosition(0, p0.position);
        line.SetPosition(1,p1.position);
        line.SetPosition(2,p2.position);
        line.SetPosition(3,p3.position);
        line.SetPosition(4,p4.position);
        line.SetPosition(5,p5.position);
        edgeCollider = line.gameObject.AddComponent<EdgeCollider2D>();
        
        List<Vector2> points = new List<Vector2>();
        points.Add(p0.position);
        points.Add(p1.position);
        points.Add(p2.position);
        points.Add(p3.position);
        points.Add(p4.position);
        points.Add(p5.position);
        edgeCollider.SetPoints(points);
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, p0.position);
        line.SetPosition(1, p1.position);
        line.SetPosition(2, p2.position);
        line.SetPosition(3, p3.position);
        line.SetPosition(4, p4.position);
        line.SetPosition(5, p5.position);

        List<Vector2> points = new List<Vector2>();
        points.Add(p0.position);
        points.Add(p1.position);
        points.Add(p2.position);
        points.Add(p3.position);
        points.Add(p4.position);
        points.Add(p5.position);

        edgeCollider.SetPoints(points);
    }
}
