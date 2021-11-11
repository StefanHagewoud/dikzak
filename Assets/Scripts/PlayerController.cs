using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerMovement")]
    public int movementSpeed;

    [Header("Raycast Settings")]
    private Vector3 raycastHitPostion;
    private RaycastHit raycastHit;

    [Header("Gun Settings")]
    public GameObject gun;
    public GameObject bullet;
    public int blastPower;
    public int damage;
    public int maxAmmo;
    public int curAmmo;
    public GameObject shootingPoint;


    // Start is called before the first frame update
    void Start()
    {
        curAmmo = maxAmmo;
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

        GetComponent<Transform>().Translate(move * Time.deltaTime * movementSpeed);

        //Camera
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point); // Look at the point
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0)); // Clamp the x and z rotation
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (curAmmo >= 1)
            {
                Debug.Log("It works");
                Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray2, out raycastHit, 100f))
                {
                    if (raycastHit.transform != null)
                    {
                        Shoot();
                    }
                }
            }
        }
    }
    public void Shoot()
    {
        Debug.Log("Shot!");
        curAmmo--;
        GameObject createdBullet = Instantiate(bullet, shootingPoint.transform.position, shootingPoint.transform.rotation);
        createdBullet.GetComponent<Rigidbody>().velocity = shootingPoint.transform.forward * blastPower;
    }
}
