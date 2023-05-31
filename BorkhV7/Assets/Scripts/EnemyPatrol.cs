using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
   public float speed;
    public int startpoint;
    public Transform[] points;
    public float rotationAngle = 90f;
    public float rotationAngley = 180f;
    public float rotationAngleyb = 0f;
    
    private Vector3 lastPosition;

    private int i;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startpoint].position;
        lastPosition = transform.position;
        
    }

    public Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = transform.position - lastPosition;

        direction = delta.normalized;
         
         
         

        if (Mathf.Abs(direction.y) > 0.1f)
        {
           
            if (Mathf.Abs(direction.y) > 0f)
            {
                 
                //se a posição de y for menor que a última posição = y diminuir
                 if (transform.position.y < lastPosition.y)
                {
                /// faz o eixo Z ficar em 0
                transform.rotation = Quaternion.Euler(0, 0, rotationAngleyb);
                }
                 
                 else
                 {
                transform.rotation = Quaternion.Euler(0, 0, rotationAngley);
                 }
            }
            else if (Mathf.Abs(direction.x) > 0f)
            {
                transform.rotation = Quaternion.Euler(0, 0, -rotationAngley);
            }
            
        }
        else if (Mathf.Abs(direction.x) > 0.1f)
        {

              if (direction.x > 0 )
            {
                transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
            }
            else if (direction.x < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, -rotationAngle);
            }
            
        }


        lastPosition = transform.position;
        
        if(Vector2.Distance(transform.position, points[i].position ) < 0.05f )
        {
            i++;
            if(i == points.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
