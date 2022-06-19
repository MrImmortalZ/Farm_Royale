using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;
    
    //Animator m_Animator;
    Rigidbody m_Rigidbody;
    public GameObject projectilePrefab;
    //AudioSource m_AudioSource;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        //m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
        //m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * speed * Time.deltaTime);
        
        //bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        //bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        //bool isWalking = hasHorizontalInput || hasVerticalInput;
        //m_Animator.SetBool("IsWalking", isWalking);

        /*if (isWalking)
        {
            if (!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }

        }
        else
        {
            m_AudioSource.Stop();
        }*/
         if(Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile
            Instantiate(projectilePrefab, transform.position,projectilePrefab.transform.rotation);
        }
    }
    /*void OnAnimatorMove()
    {
        m_Rigidbody.MovePosition(m_Rigidbody.position + m_Movement * mdeltaPosition.magnitude);
        m_Rigidbody.MoveRotation(m_Rotation);
    }*/
}
