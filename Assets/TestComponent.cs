using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    [SerializeField] string text;
    public OtherTest other;
    // Start is called before the first frame update
    void Start()
    {
        var others = FindObjectOfType<OtherTest>();
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(other.Amount);
    }
}
