using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerMotor))]
//GDW GAME MOVEMENT CODE
public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;

    private PlayerMotor motor;

    private Vector3 location;
    private Vector3 savedLoc;

    public Text xCoord;
    public Text yCoord;
    public Text zCoord;


    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        //update UI to show location
        xCoord.text = "X: " + transform.localPosition.x.ToString(); 
        yCoord.text = "Y: " + transform.localPosition.y.ToString(); 
        zCoord.text = "Z: " + transform.localPosition.z.ToString(); 

        //get current location of player
        location = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);

        if (Input.GetButton("Fire3"))
        {
            speed = 15f;
        }
        else
        {
            speed = 5f;
        }

        //calculate movement velocity as 3D vec

        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMove;
        Vector3 moveVertical = transform.forward * zMove;

        //our final movement vector
        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        //apply the movement

        motor.Move(velocity); 

        //calculate rotation as 3D vec: Only for character to turn around
        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, yRot, 0f) * lookSensitivity;

        //apply player rotation
        motor.Rotate(_rotation);

        //calculate rotation as 3D vec: Only for Camera Look Around
        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 _CamRotation = new Vector3(xRot, 0f, 0f) * lookSensitivity;

        //apply Camera rotation
        motor.CamRotate(_CamRotation);
        
    }

}
