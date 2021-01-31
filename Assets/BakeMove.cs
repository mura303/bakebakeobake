using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeMove : MonoBehaviour
{
    public GameObject m_Target;
    public string m_ControllerId;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Target.transform.position += new Vector3(Input.GetAxis("Horizontal"+ m_ControllerId) / 10,
            Input.GetAxis("Vertical"+m_ControllerId) / 10, 0);

        if (Input.GetButtonDown("Left" + m_ControllerId))
        {
            float minx = -10000;
            foreach( GameObject g in GameObject.FindGameObjectsWithTag("Player" ) )
            {

            }
            Debug.Log("lbutton");
        }

        if (Input.GetButtonDown("Right"+m_ControllerId))
        {
            Debug.Log("rbutton");
        }
    }
}
