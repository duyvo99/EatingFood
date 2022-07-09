using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{

    private bool isMouseDown = false;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        //kiểm tra có thể nhấn chuột giữ con chuột để cho vật di chuyển theo con chuột
        if(Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }    

        if(Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
        }    


        
        //xác định vị trí con chuột tọa độ theo pixel
        Debug.Log(Input.mousePosition);

        //xác định vị trí con chuột tọa độ theo Unity
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePosition);
        


        //////di chuyển theo con chuột
        //cho vật luôn xuất hiện trên camera
        mousePosition.z = 0;


        if(isMouseDown)
        {

            //gán lại vị trí vật => lúc này vật đã di chuyển theo con trỏ chuột
            transform.position = mousePosition;

        }    
        
    }
}
