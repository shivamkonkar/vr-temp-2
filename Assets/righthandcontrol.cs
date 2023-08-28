
using UnityEngine;
using UnityEngine.InputSystem;

public class righthandcontrol : MonoBehaviour
{

    public InputActionProperty primarykeypressed;
    public InputActionProperty leftgrippressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float primaryvalue = primarykeypressed.action.ReadValue<float>();
        if (primaryvalue > 0f)
        {
            Debug.Log(primaryvalue + "key pressed");
        }

        float leftgrip = leftgrippressed.action.ReadValue<float>();
        if (leftgrip > 0f)
        {
            Debug.Log(leftgrip);
        }


    }
}
