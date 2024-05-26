using UnityEngine;

public class PLAYER : MonoBehaviour
{

    public static float VIDA = 100;
    CharacterController controller;
    public GameObject gameOverCanvas;
    Vector3 forward;
    Vector3 strafe;
    Vector3 vertical;
    float forwardSpeed = 6f;
    float strafeSpeed = 6f;
    float gravity;
    float jumpSpeed;
    float maxJumpHeight = 2f;
    float timeToMaxHeight = 0.5f;
    bool isGameOver = false;

    void Start()
    {
        VIDA = 100;
        gameOverCanvas.SetActive(false);
        controller = GetComponent<CharacterController>();
        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / timeToMaxHeight;
    }

    void Update()
    {
        float forwardInput = Input.GetAxisRaw("Vertical"); //1W e -1S
        float strafeInput = Input.GetAxisRaw("Horizontal"); //1D e -1A
        //Force = input * speed * direction
        forward = forwardInput * forwardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;
        vertical += gravity * Time.deltaTime * Vector3.up;

        if (controller.isGrounded)
        {
            vertical = Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            vertical = jumpSpeed * Vector3.up;
        }
        if (vertical.y > 0 && (controller.collisionFlags & CollisionFlags.Above) != 0)
        {
            vertical = Vector3.zero;
        }
        Vector3 finalVelocity = forward + strafe + vertical;
        controller.Move(finalVelocity * Time.deltaTime);

        if (VIDA <= 0 && !isGameOver) // Verifica se a vida acabou e se o jogo já não está em game over
        {
            isGameOver = true; 
            ChamaGameOver();
        }
    }

    void ChamaGameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("morreu");
    }

}
