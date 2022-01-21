using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;

    [Header("Views")]
    public Transform startingView;
    public Transform firstComputer;
    public Transform secondComputer;
    public Transform bookView;

    // Use this for initialization
    void Start()
    {


    }
    private void Awake()
    {
        currentView = startingView;
    }

    void Update()
    {
        if( currentView == startingView)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("no");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if(hit.collider.tag == "Computer1")
                    {
                        currentView = firstComputer;
                    }
                    if (hit.collider.tag == "Computer2")
                    {
                        currentView = secondComputer;
                    }
                    if(hit.collider.tag == "Book")
                    {
                        currentView = bookView;
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currentView = startingView;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentView = views[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentView = views[1];
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentView = views[2];
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentView = views[3];
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentView = views[4];
        }

    }


    void LateUpdate()
    {

        //Lerp position
        this.gameObject.transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(
         Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;

    }

    public void StartingView()
    {
        currentView = startingView;
    }
}
