using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolDi : MonoBehaviour
{
   public float speed;
    public int startpoint;
    public Transform[] points;
    

    private Animator Vermelho;
    
    private Vector3 lastPosition;

    int Frente = Animator.StringToHash("Frente");
    int Tras = Animator.StringToHash("Tras");
    int Direita = Animator.StringToHash("Direita");
    int Esquerda = Animator.StringToHash("Esquerda");

    private int i;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startpoint].position;
        lastPosition = transform.position;
        
    }

    void Awake()
    {
        Vermelho = GetComponent<Animator>();
    }

    public Vector3 direction;

                //Vermelho.SetBool(Frente, true);
                //Vermelho.SetBool(Direita, false);
                //Vermelho.SetBool(Esquerda, false);
                //Vermelho.SetBool(Tras, true);

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
                
                Vermelho.Play("RoboVer1");
                Vermelho.Play("RoboVer2");
                Vermelho.Play("RoboVer3");
                }
                 
                 else
                 {
                    
                    Vermelho.Play("RoboVer12");
                    Vermelho.Play("RoboVer22");
                    Vermelho.Play("RoboVer32");
                 }
            }
            else if (Mathf.Abs(direction.x) > 0f)
            {
                
                Vermelho.Play("RoboVer1");
                Vermelho.Play("RoboVer2");
                Vermelho.Play("RoboVer3");
            }
            
        }
        else if (Mathf.Abs(direction.x) > 0.1f)
        {

              if (direction.x > 0 )
            {
                
                Vermelho.Play("RoboVer13");
                Vermelho.Play("RoboVer23");
                Vermelho.Play("RoboVer33");
            }
            else if (direction.x < 0)
            {
                
                Vermelho.Play("RoboVer14");
                Vermelho.Play("RoboVer24");
                Vermelho.Play("RoboVer34");
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
