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

    public AudioClip[] footstepClips;
    public AudioClip[] footstepClips2;
    public AudioClip[] footstepClips3;
    public AudioClip gameover;
    public AudioClip win;
    public AudioSource audioSource;
    public float footstepRate;
    private float lastFootstepTime;
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
            audioSource.PlayOneShot(gameover);
            

        }
        if (other.CompareTag("win") && coun.text== "15 / 15")
        {
            isWin = true;
            audioSource.PlayOneShot(win);
        }
        
    }

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W)) {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
            if (Time.time - lastFootstepTime > footstepRate && !animator.GetBool("walkingToR"))
            {
                lastFootstepTime = Time.time;
                audioSource.PlayOneShot(footstepClips[Random.Range(0, footstepClips.Length)]);
            }
                }
        else
            animator.SetBool("isWalking", false);

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalkingBack", true);
            transform.Translate(new Vector3(0, 0, -2f) * Time.deltaTime);
            if (Time.time - lastFootstepTime > footstepRate && !animator.GetBool("walkingToR"))
            {
                lastFootstepTime = Time.time;
                audioSource.PlayOneShot(footstepClips[Random.Range(0, footstepClips.Length)]);
            }
        }
        else
            animator.SetBool("isWalkingBack", false);

        if (animator.GetBool("isWalking") && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("walkingToR", true);
            transform.Translate(new Vector3(0, 0, 5f) * Time.deltaTime);
            if (Time.time - lastFootstepTime > footstepRate)
            {
                lastFootstepTime = Time.time;
                audioSource.PlayOneShot(footstepClips2[Random.Range(0, footstepClips2.Length)]);
            }
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
            if (Time.time - lastFootstepTime > footstepRate)
            {
                lastFootstepTime = Time.time;
                audioSource.PlayOneShot(footstepClips3[Random.Range(0, footstepClips3.Length)]);
            }
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
