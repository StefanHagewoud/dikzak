using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour
{
    public GameObject player;

    [Header("Gun Settings")]
    public int blastPower;
    public int damage;
    public GameObject shootingPoint;
    public bool automaticGun;
    public string gunName;
    public ParticleSystem muzzleFlash;

    [Header("Ammo Settings")]
    public GameObject bullet;
    public int maxAmmo;
    public int curAmmo;
    public int maxClipAmmo;
    private int clipSize;

    [Header("Gun Text UI")]
    public Text clipAmmoText;
    public Text curAmmoText;
    public Text equippedGunText;

    [Header("Automatic Gun Settings")]
    public float fireRate;
    public float lastfired;

    [Header("Sound Settings")]
    public AudioSource shootingSound;
    public AudioSource reloadSound;
    public AudioSource dryFire;

    // Start is called before the first frame update
    void Start()
    {
        //Searching the Player
        player = GameObject.Find("Player");

        //Current Ammo
        curAmmo = maxAmmo;
        curAmmoText.text = curAmmo.ToString();
        clipSize = maxAmmo;

        //Max Clip Ammo
        maxClipAmmo = maxAmmo * 15;
        clipAmmoText.text = maxClipAmmo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(automaticGun == true)
        {
            if (Input.GetMouseButton(0))
            {
                if(curAmmo >= 1)
                {
                    if (Time.time - lastfired > 1 / fireRate)
                    {
                        lastfired = Time.time;
                        Shoot();
                    }
                }
                else
                {
                    dryFire.Play();
                }
            }
        }
        else
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (curAmmo >= 1)
                {
                    Shoot();
                }
                else
                {
                    dryFire.Play();
                }
            }
        }

        //reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (curAmmo == 0)
            {
                Reload();
            }
        }
        if(this.gameObject.activeInHierarchy == true)
        {
            LoadAllVariables();
        }
    }

    public void Shoot()
    {
        shootingSound.Play();
        Debug.Log("Shot!");
        muzzleFlash.Play();
        curAmmo-- ;
        GameObject createdBullet = Instantiate(bullet, shootingPoint.transform.position, shootingPoint.transform.rotation);
        createdBullet.GetComponent<Rigidbody>().velocity = shootingPoint.transform.forward * blastPower;
        curAmmoText.text = curAmmo.ToString();
    }
    public void Reload()
    {
        if (maxClipAmmo >= 1)
        {
            maxClipAmmo -= clipSize;
            clipAmmoText.text = maxClipAmmo.ToString();
            curAmmo += clipSize;
            curAmmoText.text = curAmmo.ToString();
            reloadSound.Play();
        }
        else
        {
            return;
        }
    }

    public void LoadAllVariables()
    {
        curAmmoText.text = curAmmo.ToString();
        clipAmmoText.text = maxClipAmmo.ToString();
        equippedGunText.text = gunName;
    }
}
