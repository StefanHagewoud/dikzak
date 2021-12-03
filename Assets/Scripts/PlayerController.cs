using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Header("Playerhealth Settings")]
    public int playerHealth = 100;
    public Slider healthSlider;

    [Header("PlayerMovement")]
    public int movementSpeed;
    private Animator animator;
    private Vector3 lastPos;

    [Header("Gun")]
    public GameObject assaultRifle;
    public GameObject pistol;
    public GameObject equippedGun;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3();
        move.x = h;
        move.z = v;

        GetComponent<Transform>().Translate(move * Time.deltaTime * movementSpeed, Space.World);

        if(this.gameObject.transform.position != lastPos)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
        lastPos = this.gameObject.transform.position;

        //Camera
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point); // Look at the point
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0)); // Clamp the x and z rotation
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwapGun();
        }

        //Juiste Geweer animaties
        RightGunAnimations();
    }
    public void SwapGun()
    {
        if(pistol.activeInHierarchy == true)
        {
            pistol.SetActive(false);
            assaultRifle.SetActive(true);
            equippedGun = assaultRifle;
            return;
        }
        if(assaultRifle.activeInHierarchy == true)
        {
            assaultRifle.SetActive(false);
            pistol.SetActive(true);
            equippedGun = pistol;
            return;
        }
    }
    public void RightGunAnimations()
    {
        if (assaultRifle.activeInHierarchy == true)
        {
            animator.SetBool("assaultRifle", true);
        }
        else { animator.SetBool("assaultRifle", false); }

        if (pistol.activeInHierarchy == true)
        {
            animator.SetBool("pistol", true);
        }
        else { animator.SetBool("pistol", false); }
    }
}
