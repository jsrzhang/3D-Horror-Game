
using UnityEngine;

public class tracker : MonoBehaviour
{

    public Transform cameraPos; // gets transn of camera pos
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraPos.position; // sets location to pos of cam position
    }
}
