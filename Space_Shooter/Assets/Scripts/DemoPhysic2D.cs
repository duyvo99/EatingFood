using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPhysic2D : MonoBehaviour
{

    public Animator animator;

    public bool isFood;

    public int score;

    public int lives;


    public UIManager uiManager;

    public NewDemoCode spawnManager;

    ///////TỰ LÀM
    //WCanvas_TuLam wcanvas;
    //////TỰ LÀM CUỐI

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        ///////TỰ LÀM
        //wcanvas = FindObjectOfType<WCanvas_TuLam>();

        
        //////TỰ LÀM CUỐI
    }

    public void StartGame()
    {
        score = 0;

        lives = 3;

        animator.gameObject.SetActive(true);

        //Spawn Manager spawn food
        spawnManager.SpawnFood();

        //UI
        uiManager.SetScore(score);

        uiManager.SetLives(lives);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        ///////TỰ LÀM
        //if(collision.gameObject.CompareTag("Food"))
        //{
        //////TỰ LÀM CUỐI


            Destroy(collision.gameObject);

            //transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);

            animator.SetTrigger("Eat");
            
            if(collision.tag == "Food")
            {
                isFood = true;
            }

            else
            {
                isFood = false;
            }

        //}


        ///////TỰ LÀM
        //else if (collision.gameObject.CompareTag("FuckFood"))
        //{
        


            //Destroy(collision.gameObject);

            //wcanvas.Hurt();

            //transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);

            //animator.SetTrigger("Eat_Fuck");

            


        //}

        //////TỰ LÀM CUỐI




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);

        transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
    }

    //set cho bên 
    public void SetAnimationEat()
    {
        if(isFood)
        {
            animator.SetTrigger("Eat_Full");
            
            score++;

            //UI
            uiManager.SetScore(score);
        }

        else
        {
            animator.SetTrigger("Eat_Fuck");
            
            lives--;

            //UI
            uiManager.SetLives(lives);

            if(lives <= 0)
            {
                // game over
                animator.gameObject.SetActive(false);

                uiManager.ShowGameOver();

                //Spawn Manager stop spawn
                spawnManager.StopSpawnFood();
            }
        }
    }
}
