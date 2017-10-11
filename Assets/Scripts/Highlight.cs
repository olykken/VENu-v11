using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {

    public Material mat;
    public Material highlight;
    private Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponentInChildren<Canvas>()==true)
        {
            rend.material = highlight;
        }
        else
        {
            rend.material = mat;
        }
    }
}
