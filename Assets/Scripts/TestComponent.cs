using UnityEngine;

public class TestComponent : MonoBehaviour
{
    public MeshRenderer mr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Test");
        if (mr == null)
        {
            mr = GetComponent<MeshRenderer>();
        }
        mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Test Update in TestComponent");
        mr.enabled = !mr.enabled;
    }
}
