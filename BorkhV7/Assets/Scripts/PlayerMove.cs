using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float playerspeed = 4f;
    
    private bool ganhou;
    public GameObject victoria;
    private Animator sarahanima;
    public GameObject medalhaF;
    public GameObject medalhaM;
    public GameObject medalhaD;
    private float delay;
    public GameObject medalhaR;
    public DialogueCont diaCont;
    public DialogueCont diaCont2;
    public DialogueCont diaCont3;
    public DialogueCont diaCont4; 
    public DialogueCont diaCont5;  
    public DialogueCont diaCont6;
    public DialogueCont diaCont7;               
    public GameObject SarahUI;
   


    int correndoEs = Animator.StringToHash("CorrendoEs");
    int correndoDi = Animator.StringToHash("CorrendoDi");
    int correndoTr = Animator.StringToHash("CorrendoTr");
    int correndoFr = Animator.StringToHash("CorrendoFr");
    
    
    

    public Rigidbody2D rb;

    Vector2 movement;

    void Start()
    {
        playerspeed = 0f;
                
        
        ganhou = false;
        sarahanima = GetComponent<Animator>();
        medalhaF.SetActive(false);
        medalhaM.SetActive(false);
        medalhaD.SetActive(false);
        medalhaR.SetActive(false);
        StartCoroutine(Comeco());

        
    }

    private void OnTriggerEnter2D(Collider2D col )
    {

        if(col.CompareTag("Saida") == true)
        {
            ganhou = true;
        }

        if(col.gameObject.tag == "Medalha")
        {
            medalhaF.SetActive(true);
        }

        if(col.gameObject.tag == "MedalhaM")
        {
            medalhaM.SetActive(true);
        }

        if(col.gameObject.tag == "MedalhaD")
        {
            medalhaD.SetActive(true);
        }

        if(col.gameObject.tag == "MedalhaR")
        {
            medalhaR.SetActive(true);
        }


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Louis")
        {
            SarahUI.SetActive(true);
            DialogurMana.Instance.StartConversation(diaCont);
            
            
            
        }

        
            
            if(collision.gameObject.tag == "Mei Hua")
        {
            SarahUI.SetActive(true);
            DialogurMana.Instance.StartConversation(diaCont2);
            
            
        }
            if(collision.gameObject.tag == "Abby")
        {
            SarahUI.SetActive(true);
            DialogurMana.Instance.StartConversation(diaCont3);
            
            
        }
            if(collision.gameObject.tag == "Frederico")
        {
            SarahUI.SetActive(true);
            DialogurMana.Instance.StartConversation(diaCont4);
            
            
        }
             if(collision.gameObject.tag == "Stefani")
        {
            SarahUI.SetActive(true);
            DialogurMana.Instance.StartConversation(diaCont5);
            
            
        }
            if(collision.gameObject.tag == "Akio")
        {
            SarahUI.SetActive(true);
            DialogurMana.Instance.StartConversation(diaCont6);
            
            
        } 
             if(collision.gameObject.tag == "Arabella")
        {
            SarahUI.SetActive(true);
            DialogurMana.Instance.StartConversation(diaCont7);
            
        }
         
        



                              

    } 
     
     public IEnumerator Comeco()
     {
        yield return new WaitForSeconds(8.5f);
        playerspeed = 2.5f;


     }

    





    // Start is called before the first frame update
    void Update()
    {

        bool esquerda = false;
        bool direita = false;
        bool frente = false;
        bool atras = false;

        if (Input.GetButton("MENU"))
        {
            SceneManager.LoadScene("MenuI");
        }

        if(Input.GetAxisRaw("HORIZONTAL0") < 0)
        {
            esquerda = true;
            if (esquerda == true && direita == false)
            {
            sarahanima.SetBool(correndoEs, true);
            GetComponent<AudioSource>().UnPause();
            }
        }
         else
        {
            sarahanima.SetBool(correndoEs, false);
            esquerda = false;
            GetComponent<AudioSource>().Pause();
        }
         
         if(Input.GetAxisRaw("HORIZONTAL0") > 0)
        {
            direita = true;
            if (direita == true && esquerda == false)
            {
            sarahanima.SetBool(correndoDi, true);
            GetComponent<AudioSource>().UnPause();
            }
        }
        else
        {
            sarahanima.SetBool(correndoDi, false);
            direita = false;
            GetComponent<AudioSource>().Pause();
        }
       
        if(Input.GetAxisRaw("VERTICAL0") < 0)
        {
            frente = true;
            if (frente == true && atras == false)
            sarahanima.SetBool(correndoFr, true);
            GetComponent<AudioSource>().UnPause();
        }
        else
        {
            sarahanima.SetBool(correndoFr, false);
            frente = false;
            GetComponent<AudioSource>().Pause();
        }
        
        if(Input.GetAxisRaw("VERTICAL0") > 0)
        {
            atras = true;
            if (atras == true && frente == false)
            sarahanima.SetBool(correndoTr, true);
            GetComponent<AudioSource>().UnPause();

        }
        else
        {
            sarahanima.SetBool(correndoTr, false);
            atras = false;
            GetComponent<AudioSource>().Pause ();
        }
        
        
        movement.x = Input.GetAxis("HORIZONTAL0");
        movement.y = Input.GetAxis("VERTICAL0");
        movement.Normalize();
        winGame();

        delay += Time.deltaTime;

        /*if(delay < 8.45)
        {
            playerspeed = 0f;



        }
        else 
        {
            playerspeed = 2.5f;



        }*/
        

         
         

        


    }

    private void winGame()
    {
        if(ganhou == true)
        {
            playerspeed = 0;
            Cronometro.parart = true;
            victoria.SetActive(true);
            

        }


    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * playerspeed * Time.fixedDeltaTime);


    }
}
