using UnityEngine;
using System.Collections;


public class PlayerMove : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float leftRightSpeed = 4f;
    public float jumpHeight = 2.5f;
    public float gravity = -9.8f;
    public float crouchScale = 0.5f;
    public float crouchDuration = 0.2f;

    static public bool canMove = false;

    private float verticalVelocity;
    private bool isGrounded = true;
    private bool isCrouching = false;
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Always move forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (!canMove) return;

        // Left-right movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > LevelBoundary.leftSide)
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < LevelBoundary.rightSide)
                transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
        }

        // Jump
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("🟢 Jump triggered!");
            verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
            isGrounded = false;
        }

        // Apply gravity
        if (!isGrounded)
        {
            verticalVelocity += gravity * Time.deltaTime;
            transform.Translate(Vector3.up * verticalVelocity * Time.deltaTime);

            if (transform.position.y <= 0.5f) // Adjust based on ground height
            {
                transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
                isGrounded = true;
                verticalVelocity = 0f;
                Debug.Log("🟩 Landed!");
            }
        }

        // Crouch
        if (Input.GetKeyDown(KeyCode.LeftControl))
            StartCoroutine(CrouchRoutine());
    }

    private IEnumerator CrouchRoutine()
    {
        if (isCrouching) yield break;

        isCrouching = true;
        Debug.Log("🟡 Player crouching...");

        transform.localScale = new Vector3(originalScale.x, originalScale.y * crouchScale, originalScale.z);
        yield return new WaitForSeconds(crouchDuration);
        transform.localScale = originalScale;

        Debug.Log("🟢 Player stopped crouching.");
        isCrouching = false;
    }
}
