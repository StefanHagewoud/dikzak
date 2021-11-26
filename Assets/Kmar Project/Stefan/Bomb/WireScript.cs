using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireScript : MonoBehaviour
{
    // Start is called before the first frame update
    public LineRenderer line1;
    public LineRenderer line2;
    public LineRenderer line3;
    public LineRenderer line4;
    public LineRenderer line5;

    //private LineRenderer lineComponent1 = line1.GetComponent<LineRenderer>();

    public Color[] colors = new Color[] { Color.blue, Color.red, Color.green, Color.yellow, Color.magenta };

    void Start()
    {
        line1.startColor = colors[0];
        line2.startColor = colors[1];
        line3.startColor = colors[2];
        line4.startColor = colors[3];
        line5.startColor = colors[4];

        line1.endColor = colors[0];
        line2.endColor = colors[1];
        line3.endColor = colors[2];
        line4.endColor = colors[3];
        line5.endColor = colors[4];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
