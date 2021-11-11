using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerMovement")]
    public int movementSpeed;

    [Header("Raycast Settings")]
    private Vector3 raycastHitPostion;
    private RaycastHit raycastHit;

    [Header("Gun Settings")]
    public GameObject gun;
    public int blastPower;
    public int damage;
    public GameObject shootingPoint;

    [Header("Ammo Settings")]
    public GameObject bullet;
    public int maxAmmo;
    public int curAmmo;
    public int maxClipAmmo;
    private int clipSize;

    [Header("Gun Text UI")]
    public Text clipAmmoText;
    public Text curAmmoText;


    // Start is called before the first frame update
    void Start()
    {
        curAmmo = maxAmmo;
        curAmmoText.text = curAmmo.ToString();
        clipAmmoText.text = maxClipAmmo.ToString();
        clipSize = maxAmmo;
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

        //Camera
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point); // Look at the point
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0)); // Clamp the x and z rotation
        }

        //Shooting
        if (Input.GetMouseButtonDown(0))
        {
            if (curAmmo >= 1)
            {
                Shoot();
                Debug.Log("It works");
            }
           /* if(curAmmo == 0)
            {
                Reload();
            }*/
        }

        //Reloading
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(curAmmo == 0)
            {
                Reload();
            }
        }
    }
    public void Shoot()
    {
        Debug.Log("Shot!");
        curAmmo--;
        GameObject createdBullet = Instantiate(bullet, shootingPoint.transform.position, shootingPoint.transform.rotation);
        createdBullet.GetComponent<Rigidbody>().velocity = shootingPoint.transform.forward * blastPower;
        curAmmoText.text = curAmmo.ToString();
    }
    public void Reload()
    {
        maxClipAmmo -= clipSize;
        clipAmmoText.text = maxClipAmmo.ToString();
        curAmmo += clipSize;
        curAmmoText.text = curAmmo.ToString();
    }
}
