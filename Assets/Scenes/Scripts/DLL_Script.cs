using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class DLL_Script : MonoBehaviour
{
    public Color colour;
    MeshRenderer Renderer;

    [DllImport("SimplePlugin")]
    private static extern int ChangeColour();

    // Start is called before the first frame update
    void Start()
    {
        if (ChangeColour() == 1)
        {
            Renderer = GetComponent<MeshRenderer>();
            Renderer.material.color = colour;
        }
    }

}
