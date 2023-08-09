using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WalkAndRun : MonoBehaviour
{
    private Animator animator;
    public float rotationSpeed = 90f;
    private bool isOver;
    private bool isWin;
    private float delay = 2f;
    public TextMeshProUGUI coun;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fall"))
        {
            isOver = true;
        }
        if (other.CompareTag("win") && coun.text== "15 / 15")
        {
            isWin = true;
        }
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
                }
        else
            animator.SetBool("isWalking", false);

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalkingBack", true);
            transform.Translate(new Vector3(0, 0, -2f) * Time.deltaTime);
        }
        else
            animator.SetBool("isWalkingBack", false);

        if (animator.GetBool("isWalking") && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("walkingToR", true);
            transform.Translate(new Vector3(0, 0, 4f) * Time.deltaTime);
        }
        else
            animator.SetBool("walkingToR", false);

        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }
        else
            animator.SetBool("isJumping", false);

        if (isOver || isWin)
        {
            animator.SetBool("isFalling", true);
            Invoke("DelayScreen", delay);
            isOver= false;
            isWin= false;
        }
        else
        {
            animator.SetBool("isFalling", false);
        }

    }
    public void DelayScreen()
    {
        SceneManager.LoadScene("Giris");
    }
}
