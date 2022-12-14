using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fork : MonoBehaviour
{
    public bool isClick;
    public float startSpeed = 6;
    public Vector3 startPosition;
    public double returnSpeed = 0.1;
    [SerializeField] float MaxAngle;
    public Quaternion rot;
    public Quaternion q;

    void Start()
    {
        //Audio_Manager.instance.PlayinGameMusic();
        isClick = false;
        startPosition = this.transform.localEulerAngles;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Audio_Manager.instance.PlaySE(3);
            isClick = true;
        }

        if(Input.GetKeyUp(KeyCode.Return))
        {
            isClick = false;
        }

        if (isClick == true)
        {
            transform.Rotate(new Vector3(0, 0, -3));
        }
        if(isClick == false)
        {
            //transform.position = Vector3.MoveTowards(transform.position, startPosition, (float)returnSpeed);
            //transform.rotation = Quaternion.AngleAxis(2, Vector3.forward);
            transform.Rotate(Vector3.forward, 2);
        }

        Vector3 adjustment = transform.eulerAngles;

         //0`360๐-180`180ษฒฎ
        if (adjustment.x > 180) adjustment.x -= 360;
        if (adjustment.y > 180) adjustment.y -= 360;
        if (adjustment.z > 180) adjustment.z -= 360;

         //x,y,zป๊ผ๊ฬpx๐MaxAngleศบA-MaxAngleศใษฒฎ
        if (adjustment.x > MaxAngle) adjustment.x = MaxAngle;
        else if (adjustment.x < -MaxAngle) adjustment.x = -MaxAngle;
        if (adjustment.y > MaxAngle) adjustment.y = MaxAngle;
        else if (adjustment.y < -MaxAngle) adjustment.y = -MaxAngle;
        if (adjustment.z > MaxAngle) adjustment.z = MaxAngle;
        else if (adjustment.z < -MaxAngle) adjustment.z = -MaxAngle;

        // -180`180๐0`360ษ฿ท
        if (adjustment.x < 0) adjustment.x += 360;
        if (adjustment.y < 0) adjustment.y += 360;
        if (adjustment.z < 0) adjustment.z += 360;

        // ป?ฬ๑]px๐XV
        transform.eulerAngles = adjustment;

    }

    
}


